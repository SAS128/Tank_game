namespace TankGame.Logic
{
    /// <summary>
    /// enum that represents 4 directions
    /// </summary>
    public enum eDirection { NULL, LEFT, TOP, RIGHT, BOT };
    /// <summary>
    /// FieldObject`s child. Makes the objects movable
    /// </summary>
    public abstract class PlayerObject
    {
        /// <summary>
        /// Position on the field
        /// </summary>
        public Point point { get; set; }
        /// <summary>
        /// Last position useful for collision on other objects.
        /// </summary>
        public Point LastPosition { get; set; }
        /// <summary>
        /// Direction of the object. Useful for move
        /// </summary>
        public eDirection direction;
        /// <summary>
        /// The pause between one and the next move.
        /// </summary>
        public int Speed { protected set; get; }
        /// <summary>
        /// Moves the object
        /// </summary>
        public virtual void Move()
        {
            LastPosition = new Point(point.X, point.Y);
            point = GetNextPoint();
        }
        protected Point GetNextPoint()
        {
            Point pos = new Point(point.X, point.Y);
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
