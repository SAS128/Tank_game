namespace TankGame.Logic
{
    public class Projectile : PlayerObject
    {
        public int damage;
        public Projectile()
        {

        }
        public Projectile(Point point, eDirection direction)
        {
            this.Speed = 100;
            this.damage = 100;
            this.point = new Point(point.X,point.Y);
            this.direction = direction;
        }
        public override object Collision(object sender)
        {
            if (sender.GetType() == new Tank().GetType())
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
