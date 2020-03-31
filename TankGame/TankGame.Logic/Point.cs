namespace TankGame.Logic
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        /// <summary>
        /// Gets the string of point in format:"X:Y".
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string res = X.ToString();
            res += ":";
            res += Y.ToString();
            return res;
        }
    }
}
