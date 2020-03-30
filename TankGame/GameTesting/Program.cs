using TankGame.Logic;
using System;
namespace GameTesting
{
    class Program
    {

        static void SetMap(ref GameMode1V1 gamemode, string key = null)
        {
            switch (key)
            {
                case "default":
                    gamemode.field.fieldobjects[0, 4] = new Obstacle();
                    gamemode.field.fieldobjects[1, 4] = new Obstacle();
                    gamemode.field.fieldobjects[2, 4] = new Obstacle();
                    gamemode.field.fieldobjects[3, 4] = new Obstacle();
                    gamemode.field.fieldobjects[4, 4] = new Obstacle();
                    gamemode.field.fieldobjects[5, 4] = new Obstacle();
                    gamemode.field.fieldobjects[6, 4] = new Obstacle();
                    gamemode.field.fieldobjects[7, 4] = new Obstacle();
                    gamemode.field.fieldobjects[8, 4] = new Obstacle();
                    gamemode.field.fieldobjects[9, 4] = new Obstacle();

                    gamemode.field.fieldobjects[0, 0] = new Obstacle();
                    gamemode.field.fieldobjects[1, 0] = new Obstacle();
                    gamemode.field.fieldobjects[2, 0] = new Obstacle();
                    gamemode.field.fieldobjects[3, 0] = new Obstacle();
                    gamemode.field.fieldobjects[4, 0] = new Obstacle();
                    gamemode.field.fieldobjects[5, 0] = new Obstacle();
                    gamemode.field.fieldobjects[6, 0] = new Obstacle();
                    gamemode.field.fieldobjects[7, 0] = new Obstacle();
                    gamemode.field.fieldobjects[8, 0] = new Obstacle();
                    gamemode.field.fieldobjects[9, 0] = new Obstacle();

                    gamemode.field.fieldobjects[0, 1] = new Obstacle();
                    gamemode.field.fieldobjects[0, 2] = new Obstacle();
                    gamemode.field.fieldobjects[0, 3] = new Obstacle();
                    gamemode.field.fieldobjects[9, 1] = new Obstacle();
                    gamemode.field.fieldobjects[9, 2] = new Obstacle();
                    gamemode.field.fieldobjects[9, 3] = new Obstacle();


                    break;
                default:
                    gamemode.field.fieldobjects[0, 4] = new Obstacle();
                    gamemode.field.fieldobjects[1, 4] = new Obstacle();
                    gamemode.field.fieldobjects[2, 4] = new Obstacle();
                    gamemode.field.fieldobjects[4, 4] = new Obstacle();
                    gamemode.field.fieldobjects[5, 4] = new Obstacle();
                    gamemode.field.fieldobjects[6, 4] = new Obstacle();
                    gamemode.field.fieldobjects[7, 4] = new Obstacle();
                    gamemode.field.fieldobjects[8, 4] = new Obstacle();
                    gamemode.field.fieldobjects[9, 4] = new Obstacle();
                    gamemode.field.fieldobjects[1, 3] = new Obstacle();
                    gamemode.field.fieldobjects[4, 3] = new Obstacle();
                    gamemode.field.fieldobjects[8, 3] = new BonusGenerator();
                    (gamemode.field.fieldobjects[8, 3] as BonusGenerator).SetNewRandomBonus();
                    break;
            }
        }

        static void Main(string[] args)
        {
            Player player1 = new Player(1, new Point(1, 1));
            Player player2 = new Player(2, new Point(3, 3));
            GameMode1V1 room = new GameMode1V1(player1, player2);
            SetMap(ref room, "default1");
            Draw(ConvertGameModeToGUIData.ModifyField(ConvertGameModeToGUIData.ModifyField(ConvertGameModeToGUIData.ConvertFieldToNumbers(room.field), player1), player2));
            player1.ActionHappened += delegate {
                Console.Clear();
                Draw(ConvertGameModeToGUIData.ModifyField(ConvertGameModeToGUIData.ModifyField(ConvertGameModeToGUIData.ConvertFieldToNumbers(room.field), player1), player2)); };
            player2.ActionHappened += delegate {
                Console.Clear();
                Draw(ConvertGameModeToGUIData.ModifyField(ConvertGameModeToGUIData.ModifyField(ConvertGameModeToGUIData.ConvertFieldToNumbers(room.field), player1), player2)); };
            while(player1.tank.CurrentHealthPoints>0) 
            {
                eDirection dir = ReadKey(Console.ReadKey().Key);
                if(dir != eDirection.NULL)
                    player1.MoveTank(dir);
                else
                {
                    player1.CreateProjectile();
                }

                Console.WriteLine();
                player1.tank.CurrentHealthPoints -= 10;
                Console.Write($"{player1.tank.CurrentHealthPoints}/{player1.tank.MaxHealthPoints}");
            }
            //for (int i = 0; i < 10; i++)
            //{
            //    player1.MoveTank(eDirection.RIGHT);
            //    Console.WriteLine();
            //    Draw(ConvertGameModeToGUIData.ModifyField(ConvertGameModeToGUIData.ConvertFieldToNumbers(room.field), player1));
            //}
        }

        private static void Player1_ActionHappened(Player player)
        {
            throw new NotImplementedException();
        }

        static void Draw(NumberField field)
        {
            int width = field.SizeX;
            int height = field.SizeY;
            for (int i = height - 1; i >= 0; i--)
            {
                for (int j = 0; j < width; j++)
                {
                    switch (field.positions[j, i])
                    {
                        case 0:
                            Console.BackgroundColor = ConsoleColor.White;
                            break;
                        case 1:
                            Console.BackgroundColor = ConsoleColor.Green;
                            break;
                        case 2:
                            Console.BackgroundColor = ConsoleColor.Blue;
                            break;
                        case 5:
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            break;
                        case 4:
                            Console.BackgroundColor = ConsoleColor.Magenta;
                            break;
                        case 3:
                            Console.BackgroundColor = ConsoleColor.Cyan;
                            break;
                    }
                    Console.Write(" ");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine();
            }
        }
        static eDirection ReadKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.W:
                    return eDirection.TOP;
                case ConsoleKey.A:
                    return eDirection.LEFT;
                case ConsoleKey.S:
                    return eDirection.BOT;
                case ConsoleKey.D:
                    return eDirection.RIGHT;
                case ConsoleKey.UpArrow:
                    return eDirection.TOP;
                case ConsoleKey.LeftArrow:
                    return eDirection.LEFT;
                case ConsoleKey.DownArrow:
                    return eDirection.BOT;
                case ConsoleKey.RightArrow:
                    return eDirection.RIGHT;
                default:
                    return eDirection.NULL;
            }
        }
    }
}