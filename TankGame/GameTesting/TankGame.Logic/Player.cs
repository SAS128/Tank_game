namespace TankGame.Logic
{
    class Player
    {
        public delegate void ActionHappenedHandler();
        public event ActionHappenedHandler ActionHappened;
        public Tank tank;
        public Projectile proj;
        public int teamNumber { get; private set; }
        public Player(int teamNumber, Point tankStartPoint)
        {
            this.teamNumber = teamNumber;
            tank = new Tank(tankStartPoint);
            tank.direction = eDirection.TOP;
        }
        public bool MoveTank(eDirection direction)
        {
            if (tank.direction != direction && (int)tank.direction % 2 == (int)direction % 2)
            {
                return false;
            }
            tank.direction = direction;
            tank.Move();
            ActionHappened();
            return true;
        }
        public void CreateProjectile()
        {
            proj = tank.Shoot();
            ActionHappened();
        }
    }
}