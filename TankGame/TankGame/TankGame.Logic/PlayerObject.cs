using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankGame
{
    enum eDirection { NULL, LEFT, TOP, RIGHT, BOT };
    class PlayerObject : FieldObject
    {
        public eDirection direction;
        protected uint speed;
        public virtual void Move()
        {
            point = GetNextPoint();
        }
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
