using System;
namespace TankGame.Logic
{
    class GameMode1V1
    {
        public Field field;
        public Player player1;
        public Player player2;
        private Random rand;
        public GameMode1V1(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
            field = new Field();
            rand = new Random(field.GetHashCode());
            player1.ActionHappened += new Player.ActionHappenedHandler(SyncField);
            player1.ActionHappened += new Player.ActionHappenedHandler(SyncPlayers);
            player2.ActionHappened += new Player.ActionHappenedHandler(SyncField);
            player2.ActionHappened += new Player.ActionHappenedHandler(SyncPlayers);
        }
        private void SyncField(Player player)
        {
            Point ptn = player.tank.point;
            FieldObject currentObject;
            if (ptn.X < field.size.X && ptn.Y < field.size.Y && ptn.Y >= 0 && ptn.X >= 0)
            {
                currentObject = field.fieldobjects[ptn.X, ptn.Y];
                if (currentObject != null)
                    player.tank = currentObject.Collision(player.tank) as Tank;
            }
            else
            {
                player.tank.point.X = player.tank.LastPosition.X;
                player.tank.point.Y = player.tank.LastPosition.Y;
            }
            if (player.proj != null)
            {
                ptn = player.proj.point;
                if (ptn.X < field.size.X && ptn.Y < field.size.Y && ptn.Y >= 0 && ptn.X >= 0)
                {
                    currentObject = field.fieldobjects[ptn.X, ptn.Y];
                    if (ptn != null && currentObject != null)
                        player.proj = currentObject.Collision(player.proj) as Projectile;
                }
                else
                {
                    player.proj = null;
                }
            }
        }
        private void SyncPlayers(Player player)
        {
            Player tmp = null;
            if(player==player1)
            {
                tmp = player2;
            }
            else if(player==player2)
            {
                tmp = player1;
            }
            if (tmp == null)
                return;
            if (PointEqual(player.tank.point, tmp.tank.point))
            {
                player.tank = (Tank)tmp.tank.Collision(player.tank);
            }
            if (tmp.proj!=null)
            {
                if (PointEqual(tmp.proj.point, player.tank.point))
                {
                    player.tank = (Tank)tmp.proj.Collision(player.tank);
                    if (player.tank.CurrentHealthPoints <= 0)
                        TankDestroyed(tmp, player);
                    tmp.proj = null;
                }
            }
            if(player.proj!=null)
            {
                if (PointEqual(player.proj.point,tmp.tank.point))
                {
                    player.proj = (Projectile)tmp.tank.Collision(player.proj);
                    if (tmp.tank.CurrentHealthPoints <= 0)
                        TankDestroyed(player, tmp);
                }
                if (tmp.proj != null)
                {
                    if (PointEqual(tmp.proj.point,player.proj.point))
                        player.proj = (Projectile)tmp.proj.Collision(player.proj);
                }
            }
        }
        private bool PointEqual(Point a, Point b)
        {
            if (a.X == b.X && a.Y == b.Y)
                return true;
            else
                return false;
        }
        private void TankDestroyed(Player destroyer, Player victim)
        {

            destroyer.score += 1;
            int maxX = field.size.X-1;
            int maxY = field.size.Y-1;
            int i = rand.Next(0, maxX);
            int j = rand.Next(0, maxY);
            while(field.fieldobjects[i,j]!=null&&destroyer.tank.point.X==i&&destroyer.tank.point.Y==j)
            {
                i = rand.Next(0, maxX);
                j = rand.Next(0, maxY);
            }
            victim.tank = null;
            victim.tank = new Tank(new Point(i, j));
        }
    }
}
