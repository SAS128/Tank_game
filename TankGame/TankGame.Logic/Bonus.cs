namespace TankGame.Logic
{
    public abstract class Bonus
    {
        protected int Value;
        public abstract object GiveEffect(object sender);
    }
}
