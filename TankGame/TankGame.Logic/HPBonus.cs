namespace TankGame.Logic
{
    public class HPBonus : Bonus
    {
        public HPBonus()
        {
            Value = 100;
        }

        public HPBonus(int Value)
        {
            this.Value = Value;
        }
        public override object GiveEffect(object sender)
        {
            object effect = null;
            if (sender.GetType() == new Projectile().GetType())
            {
                effect = sender;
            }
            else if (sender.GetType() == new Tank().GetType())
            {
                Tank tank = (Tank)sender;
                tank.CurrentHealthPoints += Value;
                if(tank.CurrentHealthPoints>tank.MaxHealthPoints)
                {
                    tank.CurrentHealthPoints = tank.MaxHealthPoints;
                }
                effect = tank;
            }
            return effect;
        }
    }
}
