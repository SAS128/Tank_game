namespace TankGame.Logic
{
    class Obstacle : FieldObject
    {
        Point secondpos { get; set; }
       
        public Obstacle()
        {
            point = new Point(0, 0);
            secondpos = new Point(0, 0);
         
        }

        public Obstacle(Point first,Point second)
        {
            point = first;
            secondpos = second;
        
        }

        public override object Collision(object sender)
        {
            object collision = null;
            if (sender.GetType() == new Projectile().GetType())
            {
                (sender as Projectile).direction = eDirection.NULL;
                collision = sender;
            }
            else if (sender.GetType() == new Tank().GetType())
            {
                Tank tank = (Tank)sender;
                tank.point.X = (sender as Tank).LastPosition.X;
                tank.point.Y = (sender as Tank).LastPosition.Y;
                collision = tank;
            }
            return collision;
        }
    }
}