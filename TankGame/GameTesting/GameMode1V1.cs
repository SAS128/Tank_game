namespace TankGame.Logic
{
    class GameMode1V1
    {
        public Field field;
        public Player player1;
        public Player player2;
        public GameMode1V1(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
            field = new Field();
            player1.ActionHappened += new Player.ActionHappenedHandler(SyncField);
            player2.ActionHappened += new Player.ActionHappenedHandler(SyncField);
        }
        private void SyncField()
        {
            Point ptn = player1.tank.point;
            FieldObject currentObject = field.fieldobjects[ptn.X, ptn.Y];
            if(currentObject!=null)
            {
                player1.tank = currentObject.Collision(player1.tank) as Tank;
            }
            if(player1.proj!=null)
            {
                ptn = player1.proj.point;
                currentObject = field.fieldobjects[ptn.X, ptn.Y];
                if (ptn!=null&&currentObject != null)
                {
                    player1.proj = currentObject.Collision(player1.proj) as Projectile;
                }
            }

            ptn = player2.tank.point;
            currentObject = field.fieldobjects[ptn.X, ptn.Y];
            if (currentObject != null)
            {
                player2.tank = currentObject.Collision(player2.tank) as Tank;
            }
            if (player2.proj != null)
            {
                ptn = player2.proj.point;
                currentObject = field.fieldobjects[ptn.X, ptn.Y];
                if (ptn != null && currentObject != null)
                {
                    player2.proj = currentObject.Collision(player2.proj) as Projectile;
                }
            }
        }
        public void GetInfoChangeableObjects()
        {

        }
    }
}
