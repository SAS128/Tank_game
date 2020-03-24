using System;

namespace TankGame
{
    class Tank : FieldObject
    {

        int Hpoints { get; set; }
        int Damage { get; set; }
        int Weight { get; set; }//= задержка в милесикундах(чем болье параметр веса- тем больше задержка-тем медленнее танк)
        public Tank()
        {
            position = new System.Drawing.Point(5,5);
            Hpoints = 300;
            Damage = 100;
            Weight = 300;
        }

        public Tank(System.Drawing.Point tankpos)
        {
            position = tankpos;
            Hpoints = 300;
            Damage = 100;
            Weight = 300;
        }


        public Tank(System.Drawing.Point tankpos, int Hpoints, int Damage, int Weight)
        {
           position = tankpos;
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
                        if (sender.GetType() == (new Wall()).GetType())
                        {

                        }
                    }
                }
            }
        
          
        }
    }
}
