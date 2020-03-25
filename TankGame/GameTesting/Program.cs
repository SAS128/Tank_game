using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TankGame.Logic;
namespace GameTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(1, new Point(1, 1));
            Player player2 = new Player(1, new Point(3, 3));
            GameMode1V1 room = new GameMode1V1(player1, player2);
            player1.MoveTank(eDirection.LEFT);
        }

    }
}
