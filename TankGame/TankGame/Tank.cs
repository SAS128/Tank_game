using System;
using System.Drawing;

namespace TankGame
{
    class Tank : FieldObject
    {
       public Point LastPosition { get; set; }
        int Hpoints { get; set; }
        int Damage { get; set; }
        int Weight { get; set; }//= задержка в милесикундах(чем болье параметр веса- тем больше задержка-тем медленнее танк)
        public Tank()
        {
            position = new Point(5,5);
            LastPosition = position;
            Hpoints = 300;
            Damage = 100;
            Weight = 300;
        }

        public Tank(Point tankpos)
        {
            position = tankpos;
            LastPosition = position;
            Hpoints = 300;
            Damage = 100;
            Weight = 300;
        }


        public Tank(Point tankpos, int Hpoints, int Damage, int Weight)
        {
           position = tankpos;
            LastPosition = position;
            this.Hpoints = Hpoints;
           this.Damage = Damage;
           this.Weight = Weight;
        }



        public override void Collision(ref FieldObject sender)
        {
           if (sender.GetType()==(new Bullet()).GetType())
           {

           }
           else
            {
                if (sender.GetType() == (new Bonus()).GetType())
                {

                }
                else
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
    }
}
