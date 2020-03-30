namespace TankGame.Logic
{
    class Tank : PlayerObject
    {
        public int MaxHealthPoints { get; private set; }
        public int CurrentHealthPoints { get; set; }
        int Damage { get; set; }
        int Weight { get; set; }//= задержка в милесикундах(чем болье параметр веса- тем больше задержка-тем медленнее танк)
        public Tank()
        {
            point = new Point(5,5);
            LastPosition = new Point(point.X, point.Y);
            MaxHealthPoints = CurrentHealthPoints = 300;
            Damage = 100;
            Weight = 300;
        }
        public Tank(Point tankpos)
        {
            point = tankpos;
            LastPosition = new Point(tankpos.X, tankpos.Y);
            MaxHealthPoints = CurrentHealthPoints = 300;
            Damage = 100;
            Weight = 300;
        }
        public Tank(Point tankpos, int Hpoints, int Damage, int Weight)
        {
            point = tankpos;
            LastPosition = new Point(tankpos.X, tankpos.Y);
            MaxHealthPoints = CurrentHealthPoints = Hpoints;
            this.Damage = Damage;
            this.Weight = Weight;
        }
        public Projectile Shoot()
        {
            return new Projectile(point, direction);
        }
    }
}
