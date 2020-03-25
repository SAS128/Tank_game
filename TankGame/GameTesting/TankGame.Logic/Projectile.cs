namespace TankGame.Logic
{
    class Projectile : PlayerObject
    {
        int damage;
        public Projectile()
        {

        }
        public Projectile(Point point)
        {
            this.speed = 100;
            this.damage = 100;
            this.point = point;
        }
    }
}
