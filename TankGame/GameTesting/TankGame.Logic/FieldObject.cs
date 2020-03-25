namespace TankGame.Logic
{

    abstract class FieldObject
    {
        public Point point { get; set; }
        abstract public object Collision(object sender);
    }

}
