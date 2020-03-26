namespace TankGame.Logic
{
    class HPBonus : FieldObject
    {
        int value { get; set; }
        public bool isAvailable { get; private set; }
        public int reload { get; private set; }
        public HPBonus()
        {
            point = new Point(0,0);
            value = 100;
        }

        public HPBonus(Point pos)
        {
            point = pos;
            value = 100;
        }

        public HPBonus(Point pos, string PropertyName, int value)
        {
            point = pos;
            this.value = value;
        }

        public override object Collision(object sender)
        {
            object collision = null;
            if (sender.GetType() == new Projectile().GetType())
            {
                collision = sender;
            }
            else if (sender.GetType() == new Tank().GetType())
            {
                Tank tank = (Tank)sender;
                tank.CurrentHealthPoints += value;
                tank.CurrentHealthPoints %= tank.MaxHealthPoints;
                collision = tank;
            }
            return collision;
        }
    }
}
