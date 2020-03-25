using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankGame
{
    class Projectile : PlayerObject
    {
        int damage;
        public Projectile()
        {

        }
        public Projectile(System.Drawing.Point point)
        {
            this.speed = 100;
            this.damage = 100;
            this.point = point;
        }
    }
}
