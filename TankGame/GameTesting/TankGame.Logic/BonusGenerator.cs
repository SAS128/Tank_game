using System.Threading;
using System.Threading.Tasks;
namespace TankGame.Logic
{
    class BonusGenerator : FieldObject
    {
        public delegate void BonusRespawnedHandler();
        public event BonusRespawnedHandler BonusRespawned;
        public Bonus CurrentBonus { private set; get; }
        int BonusRespawnInterval;
        Task bonusRespawn;
        public BonusGenerator()
        {
            BonusRespawnInterval = 3000;
            bonusRespawn = new Task( () => {
                Thread.Sleep(BonusRespawnInterval);
                SetNewRandomBonus();
            });
        }
        public void SetNewRandomBonus()
        {
            CurrentBonus = new HPBonus();
            BonusRespawned();
        }
        public override object Collision(object sender)
        {
            if(CurrentBonus==null)
            {
                return sender;
            }
            else
            {
                object collision = null;
                if (sender.GetType() == new Projectile().GetType())
                {
                    collision = sender;
                }
                else if (sender.GetType() == new Tank().GetType())
                {
                    collision = CurrentBonus.GiveEffect(sender);
                    CurrentBonus = null;
                    bonusRespawn = Task.Run(() =>
                    {
                        Thread.Sleep(BonusRespawnInterval);
                        SetNewRandomBonus();
                    });
                }
                return collision;
            }
        }
    }
}
