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
        public Tank tank;
        public Projectile proj;
        public int teamNumber { get; private set; }
        public Player(int teamNumber, Point tankStartPoint)
        {
            this.teamNumber = teamNumber;
            tank = new Tank(tankStartPoint);
        }
        public bool MoveTank(eDirection direction)
        {
            if (tank.direction != direction && (int)tank.direction % 2 == (int)direction % 2)
            {
                return false;
            }
            tank.direction = direction;
            tank.Move();
            return true;
        }
        public void CreateProjectile()
        {
            proj = tank.Shoot();
        }
    }
}
