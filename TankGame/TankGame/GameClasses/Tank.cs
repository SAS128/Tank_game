using System;
using System.Drawing;

namespace TankGame
{
    class Tank : PlayerObject
    {
       public Point LastPosition { get; set; }
        int Hpoints { get; set; }
        int Damage { get; set; }
        bool shootingNow { get; set; }
        public Tank()
        {
            position = new Point(5,5);
            LastPosition = position;
            Hpoints = 300;
            Damage = 100;
            speed = 300;
        }

        public Tank(Point tankpos)
        {
            position = tankpos;
            LastPosition = position;
            Hpoints = 300;
            Damage = 100;
            speed = 300;
        }


        public Tank(Point tankpos, int Hpoints, int Damage, uint Weight)
        {
           position = tankpos;
            LastPosition = position;
            this.Hpoints = Hpoints;
           this.Damage = Damage;
           this.speed = Weight;
        }


        public override void Move()
        {
            LastPosition = position;
           
            switch (eDir)
            {
                case eDirection.RIGHT:
                    position = new Point(position.X+5, position.Y);
                    break;
                case eDirection.LEFT:
                    position = new Point(position.X-5, position.Y);
                    break;
                case eDirection.BOT:
                    position = new Point(position.X, position.Y+5);
                    break;
                case eDirection.TOP:
                    position = new Point(position.X, position.Y-5);
                    break;
                case eDirection.NULL:
                    break;
            }
        }

        public void Shoot()
        {
            shootingNow = true;
            //shooting
        }

        public void ChangeDirection(eDirection newdir)
        {
            eDir = newdir;
        }


      
    }
}
