namespace TankGame.Logic
{
    public class Tank : PlayerObject, FieldObject
    {
        /// <summary>
        /// Tank`s max HP. Only get
        /// </summary>
        public int MaxHealthPoints { get; private set; }
        /// <summary>
        /// Tank`s current health.
        /// </summary>
        public int CurrentHealthPoints { get; set; }
        int Damage { get; set; }
        /// <summary>
        /// Constructor for test
        /// </summary>
        public Tank()
        {
            point = new Point(5,5);
            LastPosition = new Point(point.X, point.Y);
            MaxHealthPoints = CurrentHealthPoints = 300;
            Damage = 100;
            Speed = 300;
            direction = eDirection.TOP;
        }
        /// <summary>
        /// Sets the position of tank
        /// </summary>
        /// <param name="tankpos"></param>
        public Tank(Point tankpos)
        {
            point = tankpos;
            LastPosition = new Point(tankpos.X, tankpos.Y);
            MaxHealthPoints = CurrentHealthPoints = 300;
            Damage = 100;
            Speed = 300;
            direction = eDirection.TOP;
        }
        /// <summary>
        /// Make your tank
        /// </summary>
        /// <param name="tankpos"></param>
        /// <param name="Hpoints"></param>
        /// <param name="Damage"></param>
        /// <param name="Weight"></param>
        public Tank(Point tankpos, int Hpoints, int Damage, int Weight)
        {
            point = tankpos;
            LastPosition = new Point(tankpos.X, tankpos.Y);
            MaxHealthPoints = CurrentHealthPoints = Hpoints;
            this.Damage = Damage;
            this.Speed = Weight;
            direction = eDirection.TOP;
        }
        /// <summary>
        /// Create the projectile
        /// </summary>
        /// <returns></returns>
        public Projectile Shoot()
        {
            return new Projectile(point, direction);
        }
        /// <summary>
        /// Stops tank or get hurt by a projectile
        /// </summary>
        /// <param name="sender"></param>
        /// <returns>Modified sender</returns>
        public object Collision(object sender)
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
            return sender;
        }
    }
}
