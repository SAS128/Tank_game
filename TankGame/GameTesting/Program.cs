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
            for(int i=0; i<1000; i++)
            {
                //player1.MoveTank(eDirection.LEFT);
                //Console.WriteLine(player1.tank.point.ToString());
                //player1.MoveTank(eDirection.TOP);
                //Console.WriteLine(player1.tank.point.ToString());
                //player1.MoveTank(eDirection.RIGHT);
                //Console.WriteLine(player1.tank.point.ToString());
                //player1.MoveTank(eDirection.BOT);
                //Console.WriteLine(player1.tank.point.ToString());
                player1.MoveTank(eDirection.TOP);
                Console.WriteLine(player1.tank.point.ToString());
            }
        }

    }
}
