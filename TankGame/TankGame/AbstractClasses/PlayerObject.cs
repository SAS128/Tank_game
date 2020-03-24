
using System.Drawing;

namespace TankGame
{
    public enum eDirection { NULL, LEFT, TOP, RIGHT, BOT };
    abstract class PlayerObject
    {
       public eDirection eDir;
        public Point position;
        public uint speed;
        public abstract void Move();
        
    }
}
