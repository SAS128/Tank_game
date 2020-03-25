using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankGame
{
    class Player
    {
        Tank tank;
        Projectile proj;
        public int teamNumber { get; private set; }
        public Player(int teamNumber, Point tankStartPoint)
        {
            this.teamNumber = teamNumber;
            tank = new Tank(tankStartPoint);
        }
        public void MoveTank(eDirection direction)
        {
            if (tank.direction != direction && (int)tank.direction % 2 != (int)direction % 2)
                tank.direction = direction; 
            tank.Move();
        }
        public void CreateProjectile()
        {
            proj = tank.Shoot();
        }
        public Point GetTankCoordinates()
        {
            return tank.point;
        }
        public Point GetProjectileCoordinates()
        {
            return proj.point;
        }
    }
}
