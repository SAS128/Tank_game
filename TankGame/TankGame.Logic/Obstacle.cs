namespace TankGame.Logic
{
    /// <summary>
    /// Nothing special. Just an obstacle. Useful for its collision.
    /// </summary>
    public class Obstacle : FieldObject
    {
        public Obstacle() { }
        /// <summary>
        /// Destroys bullet, stops tank
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public object Collision(object sender)
        {
            object collision = null;
            if (sender.GetType() == new Tank().GetType())
            {
                Tank tank = (Tank)sender;
                tank.point.X = (sender as Tank).LastPosition.X;
                tank.point.Y = (sender as Tank).LastPosition.Y;
                collision = tank;
            }
            return collision;
        }
    }
}