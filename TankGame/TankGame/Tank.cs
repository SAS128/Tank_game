﻿using System;
using System.Drawing;

namespace TankGame
{
    class Tank : PlayerObject
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




        public void ChangDirectoin(eDirection newdir)
        {
            direction = newdir;
        }

        public override void Move()
        {
            LastPosition = position;
            switch(direction)
            {
                case eDirection.RIGHT:position = new Point(position.X+5,position.Y);
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
    }
}
