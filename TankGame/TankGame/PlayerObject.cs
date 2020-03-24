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
        protected eDirection direction;
        protected Point position;
        protected uint speed;
        public abstract void Move();
    }
}
