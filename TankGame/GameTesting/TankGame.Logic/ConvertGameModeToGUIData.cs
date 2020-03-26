using System;
namespace TankGame.Logic
{
    public struct NumberField
    {
        public int SizeX;
        public int SizeY;
        public int[,] positions;
    }
    static class ConvertGameModeToGUIData
    {
        /// <summary>
        /// FieldObject becomes int,
        /// null - 0,
        /// obstacle - 1,
        /// bonus - 2
        /// </summary>
        public static NumberField ConvertFieldToNumbers(Field field)
        {
            int[,] result = new int[field.size.X, field.size.Y];
            for(int i=0; i<field.size.X; i++)
            {
                for(int j=0; j<field.size.Y; j++)
                {
                    result[i, j] = FieldObjectToInt(field.fieldobjects[i, j]);
                }
            }
            return new NumberField() { SizeX = field.size.X, SizeY = field.size.Y, positions = result };
        }

        private static int FieldObjectToInt(FieldObject field)
        {
            if(field==null)
                return 0;
            Type type = field.GetType();
            if(type == new Obstacle().GetType())
                return 1;
            if (type == new HPBonus().GetType())
                return 2;
            return -1;
        }
        /// <summary>
        /// tank - 4,
        /// projectile - 5
        /// </summary>
        /// <param name="field"></param>
        /// Give here ConvertFieldToNumbersResult
        /// <param name="player"></param>
        /// 
        /// <returns></returns>
        public static NumberField ModifyField(NumberField field, Player player)
        {
            field.positions[player.tank.point.X, player.tank.point.Y] = 4;
            if(player.proj!=null)
                field.positions[player.proj.point.X, player.proj.point.Y] = 5;
            return field;
        }
    }
}
