using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankGame
{
    class GameMode1V1
    {
        public Field field;
        public Player player1;
        public Player player2;
        public TimeSpan start;
        public GameMode1V1() { }
        void SyncField()
        {
            Point ptn = player1.tank.point;
            player1.tank = field.fieldobjects[ptn.X, ptn.Y].Collision(player1.tank) as Tank;
            ptn = player1.proj.point;
            if(ptn!=null)
            {
                player1.proj = field.fieldobjects[ptn.X, ptn.Y].Collision(player1.proj) as Projectile;
            }

            ptn = player2.tank.point;
            player2.tank = field.fieldobjects[ptn.X, ptn.Y].Collision(player2.tank) as Tank;
            ptn = player2.proj.point;
            if (ptn != null)
            {
                player2.proj = field.fieldobjects[ptn.X, ptn.Y].Collision(player2.proj) as Projectile;
            }

        }
    }
}
