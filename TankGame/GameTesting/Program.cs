using TankGame.Logic;
using System;
namespace GameTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(1, new Point(1, 1));
            Player player2 = new Player(1, new Point(3, 3));
            GameMode1V1 room = new GameMode1V1(player1, player2);
            room.field.fieldobjects[0, 4] = new Obstacle();
            room.field.fieldobjects[1, 4] = new Obstacle();
            room.field.fieldobjects[2, 4] = new Obstacle();
            room.field.fieldobjects[4, 4] = new Obstacle();
            room.field.fieldobjects[5, 4] = new Obstacle();
            room.field.fieldobjects[6, 4] = new Obstacle();
            room.field.fieldobjects[7, 4] = new Obstacle();
            room.field.fieldobjects[8, 4] = new Obstacle();
            room.field.fieldobjects[9, 4] = new Obstacle();
            room.field.fieldobjects[1, 3] = new Obstacle();
            room.field.fieldobjects[4, 3] = new Obstacle();
            room.field.fieldobjects[8, 3] = new BonusGenerator();
            (room.field.fieldobjects[8, 3] as BonusGenerator).SetNewRandomBonus();
            Draw(ConvertGameModeToGUIData.ModifyField(ConvertGameModeToGUIData.ModifyField(ConvertGameModeToGUIData.ConvertFieldToNumbers(room.field), player1),player2));
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
                Console.Clear();
                Draw(ConvertGameModeToGUIData.ModifyField(ConvertGameModeToGUIData.ModifyField(ConvertGameModeToGUIData.ConvertFieldToNumbers(room.field), player1), player2));
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
        static void Draw(NumberField field)
        {
            int width = field.SizeX;
            int height = field.SizeY;
            for (int i = height-1; i >=0; i--)
            {
                for (int j = 0; j < width; j++)
                {
                    switch(field.positions[j, i])
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
                default:
                    return eDirection.NULL;
            }
        }
    }
}
