using System.Threading;
using System.Threading.Tasks;
namespace TankGame.Logic
{
    public class BonusGenerator : FieldObject
    {
        public delegate void BonusRespawnedHandler();
        /// <summary>
        /// Event occurs when bonus appears on generator
        /// </summary>
        public event BonusRespawnedHandler BonusRespawned;
        /// <summary>
        /// It is the current bonus
        /// </summary>
        public Bonus CurrentBonus { private set; get; }
        int BonusRespawnInterval;
        Task bonusRespawn;
        /// <summary>
        /// Pause before appearing a new bonus is 3000 milliseconds. Bonus is present at the beginning.
        /// </summary>
        public BonusGenerator()
        {
            SetNewRandomBonusConstr();
            BonusRespawnInterval = 3000;
            bonusRespawn = new Task( () => {
                Thread.Sleep(BonusRespawnInterval);
                SetNewRandomBonus();
            });
        }
        /// <summary>
        /// Constructor with modifying the bonus respawn pause. Bonus is present at the beginning.
        /// </summary>
        /// <param name="BonusRespawnInterval">Pause before appearing a new bonus in milliseconds</param>
        public BonusGenerator(int BonusRespawnInterval)
        {
            SetNewRandomBonusConstr();
            this.BonusRespawnInterval = BonusRespawnInterval;
            bonusRespawn = new Task(() => {
                Thread.Sleep(BonusRespawnInterval);
                SetNewRandomBonus();
            });
        }
        private void SetNewRandomBonusConstr()
        {
            CurrentBonus = new HPBonus();
        }
        private void SetNewRandomBonus()
        {
            SetNewRandomBonusConstr();
            BonusRespawned();
        }
        /// <summary>
        /// When this function called the sender will be modified by a current bonus` effect.
        /// </summary>
        /// <param name="sender">Which object called the collision</param>
        /// <returns>Sender modified by sender</returns>
        public object Collision(object sender)
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
