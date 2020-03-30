using System.Threading.Tasks;
using System.Threading;
namespace TankGame.Logic
{
    class Player
    {
        public delegate void ActionHappenedHandler(Player player);
        public event ActionHappenedHandler ActionHappened;
        public Tank tank;
        public Projectile proj;
        public int score;
        private Task stopperMove;
        private Task stopperShoot;

        public int teamNumber { get; private set; }
        public Player(int teamNumber, Point tankStartPoint)
        {
            stopperMove = new Task(() => { Thread.Sleep(tank.Speed); });
            stopperShoot = new Task(() => { Thread.Sleep(proj.Speed); while (proj != null) { Thread.Sleep(100); } });
            this.teamNumber = teamNumber;
            tank = new Tank(tankStartPoint);
            score = 0;
        }
        public bool MoveTank(eDirection direction)
        {
            //if (tank.direction != direction && (int)tank.direction % 2 == (int)direction % 2)
            //{
            //    return false;
            //}
            if(stopperMove.Status == TaskStatus.Running)
                stopperMove.Wait();
            tank.direction = direction;
            tank.Move();
            ActionHappened(this);
            stopperMove = Task.Run(() => { Thread.Sleep(tank.Speed); });

            return true;
        }
        public void CreateProjectile()
        {
            if (stopperShoot.Status == TaskStatus.Running)
                return;
            proj = tank.Shoot();
            ActionHappened(this);
            if(proj!=null)
                stopperShoot = Task.Run(() => { Thread.Sleep(proj.Speed); while (proj != null) { Thread.Sleep(100); } });
        }
    }
}