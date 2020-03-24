using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankGame.DB_Classes
{
    class User_Statistic
    {
        public int ID { get; set; }

        public int KillCount { get; set; }

        public int DeathCount { get; set; }

        public int VictoryCount { get; set; }

        public int LooseCount { get; set; }

        public int AllCountBattle { get; set; }

        public int ShortBattleCount { get; set; }

        public int LongBattleCount { get; set; }

        public int UserNameId { get; set; }
    }
}
