using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankGame
{
    abstract class PlayerObject
    {
        enum eDirection {NULL, LEFT, TOP, RIGHT, BOT};
        protected Point point;
        protected uint speed;
        public abstract void Move();
    }
}
