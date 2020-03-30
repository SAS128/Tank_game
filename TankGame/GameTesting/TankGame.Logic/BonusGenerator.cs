using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankGame.Logic
{
    class BonusGenerator : FieldObject
    {
        public Bonus CurrentBonus { private set; get; }
        int BonusRespawnInterval;
        public void SetNewRandomBonus()
        {
            CurrentBonus = new HPBonus();
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
                }
                return collision;
            }
        }
    }
}
