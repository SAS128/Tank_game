using System;
namespace TankGame.Logic
{
    public struct NumberField
    {
        public int SizeX;
        public int SizeY;
        public int[,] positions;
    }
    public static class ConvertGameModeToGUIData
    {
        /// <summary>
        /// FieldObject becomes int:
        /// null - 0,
        /// obstacle - 1,
        /// empty bonus generator - 2,
        /// bonus generator with bonus - 3
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
            if (type == new BonusGenerator().GetType())
            {
                if ((field as BonusGenerator).CurrentBonus == null)
                    return 2;
                else
                    return 3;
            }
            return -1;
        }
        /// <summary>
        /// Should be used after ConvertFieldToNumbers, to its result will be added Player`s objects. 
        /// tank LEFT - 4,
        /// tank TOP - 5,
        /// tank RIGHT - 6,
        /// tank BOTTOM - 7,
        /// projectile LEFT - 8,
        /// projectile TOP - 9,
        /// projectile RIGHT - 10,
        /// projectile BOTTOM - 11
        /// </summary>
        /// <param name="field"></param>
        /// Give here ConvertFieldToNumbers result
        /// <param name="player"></param>
        /// Give here the Player who should be added to "visualization"
        /// <returns>NumberField struct</returns>
        public static NumberField ModifyField(NumberField field, Player player)
        {
            field.positions[player.tank.point.X, player.tank.point.Y] = 3 + (int)player.tank.direction;
            if(player.proj!=null)
                field.positions[player.proj.point.X, player.proj.point.Y] = 7 + (int)player.proj.direction;
            return field;
        }
    }
}
