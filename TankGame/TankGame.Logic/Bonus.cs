namespace TankGame.Logic
{
    public abstract class Bonus
    {
        protected int Value;
        /// <summary>
        /// Abstract giving the bonus` effect to sender
        /// </summary>
        /// <param name="sender">Receives sender, almost always it is a tank</param>
        /// <returns>Modified sender</returns>
        public abstract object GiveEffect(object sender);
    }
}
