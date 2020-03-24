using System;
using System.Drawing;

namespace TankGame
{
    class Bonus : FieldObject
    {

        string PropertyName { get; set; }
        int value { get; set; }
        public Bonus()
        {
            position = new Point(0,0);
            PropertyName = "Damage";
            value = 100;
        }

        public Bonus(Point pos)
        {
            position =pos;
            PropertyName = "Damage";
            value = 100;
        }

        public Bonus(Point pos, string PropertyName, int value)
        {
            position = pos;
            this.PropertyName = PropertyName;
            this.value = value;
        }


        public override void Collision(ref FieldObject sender)
        {
            if (sender.GetType() == (new Tank()).GetType())
            {

            }
            else
            {
                if (sender.GetType() == (new Obstacle()).GetType())
                {

                }
            }
           


        }
    }
}
