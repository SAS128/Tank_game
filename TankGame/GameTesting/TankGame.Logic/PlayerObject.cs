namespace TankGame.Logic
{
    enum eDirection { NULL, LEFT, TOP, RIGHT, BOT };
    abstract class PlayerObject : FieldObject
    {
        public Point LastPosition { get; set; }
        public eDirection direction;
        public int Speed { protected set; get; }
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
        public override object Collision(object sender) { return sender; }
    }
}
