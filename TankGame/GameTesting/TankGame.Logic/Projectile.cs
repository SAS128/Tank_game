namespace TankGame.Logic
{
    class Projectile : PlayerObject
    {
        int damage;
        public Projectile()
        {

        }
        public Projectile(Point point, eDirection direction)
        {
            this.speed = 100;
            this.damage = 100;
            this.point = new Point(point.X,point.Y);
            this.direction = direction;
        }
    }
}
