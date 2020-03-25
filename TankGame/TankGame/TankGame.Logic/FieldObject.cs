using System.Drawing;
namespace TankGame
{

    abstract class FieldObject
    {
        public Point point { get; set; }
        abstract public object Collision(object sender);
    }

}
