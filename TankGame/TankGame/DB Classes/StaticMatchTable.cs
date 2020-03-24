using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankGame.DB_Classes
{
    class StaticMatchTable
    {
        public int ID { get; set; }
        public DateTime StartBattleTime { get; set; }
        public DateTime EndBattleTime { get; set; }
        public int Player1Id { get; set; }
        public int Player2Id { get; set; }
        public int IDWinner { get; set; }
    }
}
