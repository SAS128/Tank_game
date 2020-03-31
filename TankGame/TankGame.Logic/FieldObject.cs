namespace TankGame.Logic
{

    public abstract class FieldObject
    {
        public Point point { get; set; }
        abstract public object Collision(object sender);
    }

}
