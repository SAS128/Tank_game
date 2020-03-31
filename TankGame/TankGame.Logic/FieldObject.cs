namespace TankGame.Logic
{
    public interface FieldObject
    {
        /// <summary>
        /// Abstact method that should work as a relation between two FieldObjects. One, who bumped into this object. Other is this object.
        /// </summary>
        /// <param name="sender">The one who bumps</param>
        /// <returns>Result according to child class</returns>
        object Collision(object sender);
    }

}
