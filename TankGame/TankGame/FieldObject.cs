using System.Drawing;
namespace TankGame
{

    abstract class FieldObject
    {
        public Point position { get; set; }
        abstract public void Collision(ref FieldObject sender);
    }

}
