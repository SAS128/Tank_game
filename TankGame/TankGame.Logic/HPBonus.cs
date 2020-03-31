namespace TankGame.Logic
{
    /// <summary>
    /// Bonus that heals
    /// </summary>
    public class HPBonus : Bonus
    {
        /// <summary>
        /// Value of bonus is 100 HP
        /// </summary>
        public HPBonus()
        {
            Value = 100;
        }
        /// <summary>
        /// Set a value of bonus
        /// </summary>
        /// <param name="Value"></param>
        public HPBonus(int Value)
        {
            this.Value = Value;
        }
        /// <summary>
        /// Heals a tank and ignore others objects
        /// </summary>
        /// <param name="sender">To whom give the effect</param>
        /// <returns>Modified sender</returns>
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
