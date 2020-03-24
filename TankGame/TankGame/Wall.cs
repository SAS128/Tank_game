using System;
using System.Drawing;

namespace TankGame
{
    class Wall : FieldObject
    {
        Point secondpos { get; set; }
        public Wall()
        {
            position = new Point(0, 0);
            secondpos = new Point(0, 0);
        }

        public Wall(Point first,Point second)
        {
            position = first;
            secondpos = second;
        }

        public override void Collision(ref FieldObject sender)
        {
            if (sender.GetType() == (new Bullet()).GetType())
            {

            }
            else
            {
                if (sender.GetType() == (new Tank()).GetType())
                {

                }
                else
                {
                    if (sender.GetType() == (new Bonus()).GetType())
                    {

                    }
                }
            }


        }
    }
}
