namespace TankGame.Logic
{
    public class Tank : PlayerObject
    {
        public int MaxHealthPoints { get; private set; }
        public int CurrentHealthPoints { get; set; }
        int Damage { get; set; }
        public Tank()
        {
            point = new Point(5,5);
            LastPosition = new Point(point.X, point.Y);
            MaxHealthPoints = CurrentHealthPoints = 300;
            Damage = 100;
            Speed = 300;
            direction = eDirection.TOP;
        }
        public Tank(Point tankpos)
        {
            point = tankpos;
            LastPosition = new Point(tankpos.X, tankpos.Y);
            MaxHealthPoints = CurrentHealthPoints = 300;
            Damage = 100;
            Speed = 300;
            direction = eDirection.TOP;
        }
        public Tank(Point tankpos, int Hpoints, int Damage, int Weight)
        {
            point = tankpos;
            LastPosition = new Point(tankpos.X, tankpos.Y);
            MaxHealthPoints = CurrentHealthPoints = Hpoints;
            this.Damage = Damage;
            this.Speed = Weight;
            direction = eDirection.TOP;
        }
        public Projectile Shoot()
        {
            return new Projectile(point, direction);
        }
        public override object Collision(object sender)
        {
            if(sender.GetType() == new Projectile().GetType())
            {
                this.CurrentHealthPoints -= (sender as Projectile).damage;
                sender = null;
            }
            else if(sender.GetType() == new Tank().GetType())
            {
                Tank tank = (Tank)sender;
                tank.point.X = (sender as Tank).LastPosition.X;
                tank.point.Y = (sender as Tank).LastPosition.Y;
                sender = tank;
            }
            return base.Collision(sender);
        }
    }
}
