namespace TankGame.Logic
{
    public class Projectile : PlayerObject, FieldObject
    {
        /// <summary>
        /// Damage that will be dealt to tank
        /// </summary>
        public int damage;
        /// <summary>
        /// Fullfils only speed and damage both with 100
        /// </summary>
        public Projectile()
        {
            this.Speed = 100;
            this.damage = 100;
        }
        /// <summary>
        /// Sets point and direction. Speed and damage are 100.
        /// </summary>
        /// <param name="point"></param>
        /// <param name="direction"></param>
        public Projectile(Point point, eDirection direction)
        {
            this.Speed = 100;
            this.damage = 100;
            this.point = new Point(point.X,point.Y);
            this.direction = direction;
        }
        /// <summary>
        /// Make your own bullet
        /// </summary>
        /// <param name="point"></param>
        /// <param name="direction"></param>
        /// <param name="damage"></param>
        /// <param name="Speed"></param>
        public Projectile(Point point, eDirection direction, int damage, int Speed)
        {
            this.Speed = Speed;
            this.damage = damage;
            this.point = new Point(point.X, point.Y);
            this.direction = direction;
        }
        /// <summary>
        /// Hit the tank if it is a sender
        /// </summary>
        /// <param name="sender"></param>
        /// <returns>Modified sender</returns>
        public object Collision(object sender)
        {
            if (sender.GetType() == new Tank().GetType())
            {
                Tank tank = (Tank)sender;
                tank.CurrentHealthPoints -= (sender as Projectile).damage;
            }
            return sender;
        }
    }
}
