
namespace TankGame
{
    class Bullet : FieldObject
    {
        int Weight { get; set; }
        public Bullet()
        {
            position = new System.Drawing.Point();
            Weight = 100;
        }

        public Bullet(System.Drawing.Point pos)
        {
            position = pos;
            Weight = 100;
        }

        public Bullet(System.Drawing.Point pos,int Weight)
        {
            position = pos;
            this.Weight = Weight;
        }



        public override void Collision(ref FieldObject sender)
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
