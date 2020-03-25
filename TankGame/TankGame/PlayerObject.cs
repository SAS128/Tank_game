using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankGame
{
    enum eDirection { NULL, LEFT, TOP, RIGHT, BOT };
    abstract class PlayerObject
    {
        public eDirection direction;
        public Point point { get; protected set; }
        protected uint speed;
        public abstract void Move();
        protected Point GetNextPoint()
        {
            Point pos = point;
            switch (direction)
            {
                case eDirection.LEFT:
                    {
                        pos.X -= 1;
                        break;
                    }
                case eDirection.TOP:
                    {
                        pos.Y += 1;
                        break;
                    }
                case eDirection.RIGHT:
                    {
                        pos.X += 1;
                        break;
                    }
                case eDirection.BOT:
                    {
                        pos.Y -= 1;
                        break;
                    }
            }
            return pos;
        }
    }
}
