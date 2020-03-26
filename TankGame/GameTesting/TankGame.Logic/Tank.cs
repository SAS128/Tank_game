﻿namespace TankGame.Logic
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
            MaxHealthPoints = CurrentHealthPoints = 300;
            Damage = 100;
            Weight = 300;
        }
        public Tank(Point tankpos)
        {
            point = tankpos;
            LastPosition = point;
            MaxHealthPoints = CurrentHealthPoints = 300;
            Damage = 100;
            Weight = 300;
        }
        public Tank(Point tankpos, int Hpoints, int Damage, int Weight)
        {
            point = tankpos;
            LastPosition = point;
            MaxHealthPoints = CurrentHealthPoints = Hpoints;
            this.Damage = Damage;
            this.Weight = Weight;
        }
        public override void Move()
        {
            LastPosition.X = point.X;
            LastPosition.Y = point.Y;
            base.Move();
        }
        public Projectile Shoot()
        {
            return new Projectile(GetNextPoint());
        }
    }
}
