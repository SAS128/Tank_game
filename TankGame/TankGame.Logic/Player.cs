using System.Threading.Tasks;
using System.Threading;
namespace TankGame.Logic
{
    /// <summary>
    /// Works as interface between user and field
    /// </summary>
    public class Player
    {
        public delegate void ActionHappenedHandler(Player player);
        /// <summary>
        /// Occurs when any method of this player called. Useful for creating a gamemode
        /// </summary>
        public event ActionHappenedHandler ActionHappened;
        /// <summary>
        /// Player`s tank
        /// </summary>
        public Tank tank;
        /// <summary>
        /// This tank`s projectile
        /// </summary>
        public Projectile proj;
        /// <summary>
        /// Player`s score
        /// </summary>
        public int score;
        private Task stopperMove;
        private Task stopperShoot;
        /// <summary>
        /// Number of team
        /// </summary>
        public int teamNumber { get; private set; }
        /// <summary>
        /// The only one construstor
        /// </summary>
        /// <param name="teamNumber">Number of team</param>
        /// <param name="tankStartPoint">The starting position of tank</param>
        public Player(int teamNumber, Point tankStartPoint)
        {
            stopperMove = new Task(() => { Thread.Sleep(tank.Speed); });
            stopperShoot = new Task(() => { Thread.Sleep(proj.Speed); while (proj != null) { Thread.Sleep(100); } });
            this.teamNumber = teamNumber;
            tank = new Tank(tankStartPoint);
            score = 0;
        }
        /// <summary>
        /// Interface method. Moves tank in chosen direction
        /// </summary>
        /// <param name="direction">The direction of tank</param>
        /// <returns>Is succesful move</returns>
        public bool MoveTank(eDirection direction)
        {
            if(stopperMove.Status == TaskStatus.Running)
                stopperMove.Wait();
            tank.direction = direction;
            tank.Move();
            ActionHappened(this);
            stopperMove = Task.Run(() => { Thread.Sleep(tank.Speed); });

            return true;
        }
        private bool MoveProjectile()
        {
            proj.Move();
            return true;
        }
        /// <summary>
        /// Interface method. Makes the nak shoot according to its direction at the moment.
        /// </summary>
        public void CreateProjectile()
        {
            if (stopperShoot.Status == TaskStatus.Running)
                return;
            proj = tank.Shoot();
            ActionHappened(this);
            if(proj!=null)
                stopperShoot = Task.Run(() => { while (proj != null) { Thread.Sleep(proj.Speed); proj.Move(); ActionHappened(this); } });
        }
    }
}