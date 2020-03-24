using System;
using System.Drawing;

namespace TankGame
{
    class Obstacle : FieldObject
    {
        Point secondpos { get; set; }
        public Obstacle()
        {
            position = new Point(0, 0);
            secondpos = new Point(0, 0);
        }

        public Obstacle(Point first,Point second)
        {
            position = first;
            secondpos = second;
        }

        public override void Collision(ref FieldObject sender)
        {
            if (sender.GetType() == (new Bullet()).GetType())
            {
                sender.position = new Point(-20, -20);
            }
            else
            {
                if (sender.GetType() == (new Tank()).GetType())
                {
                    (sender as Tank).position = (sender as Tank).LastPosition;
                }
                //else
                //{
                //    if (sender.GetType() == (new Bonus()).GetType())
                //    {

                //    }
                //}
            }


        }
    }
}
