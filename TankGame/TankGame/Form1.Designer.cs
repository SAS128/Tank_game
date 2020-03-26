
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TankGame
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        /// 
        
        
        List<WallObject> listwalls;


        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Text = "Form1";
            this.Paint += PntMap;
            FormBorderStyle = FormBorderStyle.FixedDialog;

            listwalls = GetMap("default");


            this.KeyPreview = true;
            this.KeyDown += KeyTake;




        }

        List<WallObject> GetMap(string key = null)
        {
            var list = new List<WallObject>();
            switch(key)
            {
                case "default":
                    list.Add(new WallObject(new Point(wallwidth, 0), new Point(wallwidth, this.Height - wallwidth * 7)));
                    list.Add(new WallObject(new Point(0, wallwidth), new Point(this.Width - wallwidth * 4, wallwidth)));
                    list.Add(new WallObject(new Point(this.Width - wallwidth * 4, 0), new Point(this.Width - wallwidth * 4, this.Height - wallwidth * 7)));
                    list.Add(new WallObject(new Point(0, this.Height - wallwidth * 8), new Point(this.Width - wallwidth * 4, this.Height - wallwidth * 8)));
                    list.Add(new WallObject(new Point(100,100), new Point(100,250)));
                    list.Add(new WallObject(new Point(100, 100), new Point(250, 100)));
                    list.Add(new WallObject(new Point(100, 350), new Point(100, 500)));
                    list.Add(new WallObject(new Point(100, 500), new Point(250, 500)));
                    list.Add(new WallObject(new Point(550, 100), new Point(700, 100)));
                    list.Add(new WallObject(new Point(700, 100), new Point(700, 250)));
                    list.Add(new WallObject(new Point(700, 350), new Point(700, 500)));
                    list.Add(new WallObject(new Point(550, 500), new Point(700, 500)));
                    break;
                default:
                    list.Add(new WallObject(new Point(wallwidth, 0), new Point(wallwidth, this.Height - wallwidth * 7)));
                    list.Add(new WallObject(new Point(0, wallwidth), new Point(this.Width - wallwidth * 4, wallwidth)));
                    list.Add(new WallObject(new Point(this.Width - wallwidth * 4, 0), new Point(this.Width - wallwidth * 4, this.Height - wallwidth * 7)));
                    list.Add(new WallObject(new Point(0, this.Height - wallwidth * 8), new Point(this.Width - wallwidth * 4, this.Height - wallwidth * 8)));
                    break;
            }

            return list;
        }

        void RightMove(object sender, PaintEventArgs paintEventArgs)
        {

            if (CanRightMove() == false)
            {
                paintEventArgs.Graphics.FillRectangle(Brushes.White, tank1.pos.X, tank1.pos.Y, tank1.Width, tank1.Height);

                tank1.pos.X += pacStep;
                paintEventArgs.Graphics.FillRectangle(Brushes.GreenYellow, tank1.pos.X, tank1.pos.Y, tank1.Width, tank1.Height);
              
            }
        }

        void LeftMove(object sender, PaintEventArgs paintEventArgs)
        {

            if (CanLeftMove() == false)
            {
                paintEventArgs.Graphics.FillRectangle(Brushes.White, tank1.pos.X, tank1.pos.Y, tank1.Width, tank1.Height);
                
                tank1.pos.X -= pacStep;
                paintEventArgs.Graphics.FillRectangle(Brushes.GreenYellow, tank1.pos.X, tank1.pos.Y, tank1.Width, tank1.Height);

            }
        }


        void UpMove(object sender, PaintEventArgs paintEventArgs)
        {

            if (CanUpMove() == false)
            {
                paintEventArgs.Graphics.FillRectangle(Brushes.White, tank1.pos.X, tank1.pos.Y, tank1.Width, tank1.Height);

                tank1.pos.Y -= pacStep;
                paintEventArgs.Graphics.FillRectangle(Brushes.GreenYellow, tank1.pos.X, tank1.pos.Y, tank1.Width, tank1.Height);

            }
        }


        void DownMove(object sender, PaintEventArgs paintEventArgs)
        {

            if (CanDownMove() == false)
            {
                paintEventArgs.Graphics.FillRectangle(Brushes.White, tank1.pos.X, tank1.pos.Y, tank1.Width, tank1.Height);

                tank1.pos.Y += pacStep;
                paintEventArgs.Graphics.FillRectangle(Brushes.GreenYellow, tank1.pos.X, tank1.pos.Y, tank1.Width, tank1.Height);

            }
        }

        private void KeyTake(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                RightMove(sender, new PaintEventArgs(this.CreateGraphics(), new Rectangle()));
            }
            else
            {
                if (e.KeyCode == Keys.Left)
                {
                    LeftMove(sender, new PaintEventArgs(this.CreateGraphics(), new Rectangle()));
                }
                else
                {
                    if (e.KeyCode == Keys.Up)
                    {
                        UpMove(sender, new PaintEventArgs(this.CreateGraphics(), new Rectangle()));
                    }
                    else
                    {
                        if (e.KeyCode == Keys.Down)
                        {
                            DownMove(sender, new PaintEventArgs(this.CreateGraphics(), new Rectangle()));
                        }
                    }
                }
            }
        }

 
    private void PntMap(object sender, PaintEventArgs e)
        {
            foreach (var item in listwalls)
            {
                DrawObject(e, item.second, item.first);
            }
        }

        GameHeroObject tank1 = new GameHeroObject();

        int pacStep=10;
        int wallwidth = 5;



        private void DrawObject(PaintEventArgs e,Point second, Point first)
        {
            Pen pen1 = new Pen(Brushes.Black, wallwidth*2);
            e.Graphics.DrawLine(pen1, first,second);
        }

        private bool CanRightMove()
        {
            bool maperror = false;
            foreach (var item in listwalls)
            {
                if ((tank1.pos.Y + tank1.Height >= item.first.Y && tank1.pos.Y <= item.second.Y) || (item.first.Y == item.second.Y && item.first.Y + wallwidth > tank1.pos.Y && item.first.Y - wallwidth < tank1.pos.Y + tank1.Width))
                {
                    if (tank1.pos.X + tank1.Width <= item.first.X && (tank1.pos.X + tank1.Width + pacStep) >= item.first.X-wallwidth)
                    {
                        maperror = true;
                        break;
                    }
                }

            }
            return maperror;
           


        }

        private bool CanUpMove()
        {
            bool maperror = false;
            foreach (var item in listwalls)
            {
                if ((tank1.pos.X + tank1.Width >= item.first.X && tank1.pos.X <= item.second.X))
                {
                    if ((tank1.pos.Y >= item.first.Y+wallwidth && (tank1.pos.Y - pacStep) <= item.first.Y+wallwidth))
                    {
                        maperror = true;
                        break;
                    }
                }

                if ((item.first.X == item.second.X && item.second.X + wallwidth > tank1.pos.X && item.second.X - wallwidth < tank1.pos.X + tank1.Width))
                {
                    if ((tank1.pos.Y >= item.second.Y && (tank1.pos.Y - pacStep) <= item.second.Y))
                    {
                        maperror = true;
                        break;
                    }
                }

            }
            return maperror;


        }

        private bool CanDownMove()
        {
            bool maperror = false;
            foreach (var item in listwalls)
            {
                if ((tank1.pos.X + tank1.Width >= item.first.X && tank1.pos.X <= item.second.X))
                {
                    if ((tank1.pos.Y + tank1.Height <= item.first.Y && (tank1.pos.Y + tank1.Height + pacStep) >= item.first.Y-wallwidth))
                    {
                        maperror = true;
                        break;
                    }
                }

                if ((item.first.X == item.second.X && item.first.X - wallwidth <= tank1.pos.X+tank1.Width && item.first.X + wallwidth > tank1.pos.X))
                {
                    if ((tank1.pos.Y + tank1.Height <= item.first.Y && (tank1.pos.Y + tank1.Height + pacStep) >= item.first.Y))
                    {
                        maperror = true;
                        break;
                    }
                }

            }
            return maperror;
        }


        private bool CanLeftMove()
        {
            bool maperror = false;
            foreach (var item in listwalls)
            {
                if ((tank1.pos.Y + tank1.Height >= item.first.Y && tank1.pos.Y <= item.second.Y) || (item.first.Y == item.second.Y && item.first.Y + 5 > tank1.pos.Y && item.first.Y - 5 < tank1.pos.Y + tank1.Height))
                {
                    if (tank1.pos.X >= item.second.X && (tank1.pos.X - pacStep) <= item.second.X+wallwidth)
                    {
                        maperror = true;
                        break;
                    }
                }

            }
            return maperror;
        }



        #endregion
        class MyPoint
        {
           public int X { get; set; }
           public int Y { get; set; }
            public MyPoint()
            {
                X = 0;
                Y = 0;
            }

            public MyPoint(int x,int y)
            {
                X = x;
                Y = y;
            }
        }

        class GameHeroObject
        {
            public MyPoint pos { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }

            public GameHeroObject()
            {
                pos = new MyPoint(200, 20);
                Width = 30;
                Height = 30;
            }





        }


        class WallObject
        {
            public Point first;
            public Point second;
            public WallObject()
            {
                first = new Point();
                second = new Point();
            }

            public WallObject(Point first, Point second)
            {
                this.first = new Point(first.X, first.Y);
                this.second = new Point(second.X, second.Y);
            }

        }
    }
}

