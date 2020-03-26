using System;
namespace TankGame.Logic
{
    static class ConvertGameModeToGUIData
    {
        /// <summary>
        /// FieldObject becomes int,
        /// null - 0,
        /// obstacle - 1,
        /// bonus - 2
        /// </summary>
        public static int[,] ConvertFieldToNumbers(Field field)
        {
            int[,] result = new int[field.size.X, field.size.Y];
            for(int i=0; i<field.size.X; i++)
            {
                for(int j=0; j<field.size.Y; j++)
                {
                    result[i, j] = FieldObjectToInt(field.fieldobjects[i, j]);
                }
            }
            return result;
        }

        private static int FieldObjectToInt(FieldObject field)
        {
            Type type = field.GetType();
            if(type == new Obstacle().GetType())
                return 1;
            if(type == null)
                return 0;
            if (type == new HPBonus().GetType())
                return 2;
            return -1;
        }
    }
}
