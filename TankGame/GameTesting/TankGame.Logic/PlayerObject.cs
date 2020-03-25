namespace TankGame.Logic
{
    enum eDirection { NULL, LEFT, TOP, RIGHT, BOT };
    abstract class PlayerObject : FieldObject
    {
        public eDirection direction;
        protected uint speed;
        public virtual void Move()
        {
            point = GetNextPoint();
        }
        protected Point GetNextPoint()
        {
            Point pos = point;
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
