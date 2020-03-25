using System;
using System.Drawing;

namespace TankGame
{
    class Tank : PlayerObject
    {
        public Point LastPosition { get; set; }
        public int MaxHealthPoints { get; private set; }
        public int CurrentHealthPoints { get; set; }
        int Damage { get; set; }
        int Weight { get; set; }//= задержка в милесикундах(чем болье параметр веса- тем больше задержка-тем медленнее танк)
        public Tank()
        {
            point = new Point(5,5);
            LastPosition = point;
            Hpoints = 300;
            Damage = 100;
            Weight = 300;
        }
        public Tank(Point tankpos)
        {
            point = tankpos;
            LastPosition = point;
            Hpoints = 300;
            Damage = 100;
            Weight = 300;
        }
        public Tank(Point tankpos, int Hpoints, int Damage, int Weight)
        {
            point = tankpos;
            LastPosition = point;
            this.Hpoints = Hpoints;
           this.Damage = Damage;
           this.Weight = Weight;
        }
        public override void Move()
        {
            LastPosition = point;
            base.Move();
        }
        public Projectile Shoot()
        {
            return new Projectile(GetNextPoint());
        }
    }
}
