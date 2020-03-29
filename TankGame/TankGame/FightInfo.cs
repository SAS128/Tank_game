using System;

namespace TankGame
{
    class FightInfo
    {
        public string EnemyPlayerNickName;
        public bool isWin;
        public TimeSpan Time;
        public FightInfo()
        {
            EnemyPlayerNickName = "Random";
                isWin = true;
                Time = TimeSpan.MinValue;
        }
        public FightInfo(string EnemyPlayerNickName, bool isWin,TimeSpan Time)
        {
            this.EnemyPlayerNickName = EnemyPlayerNickName;
            this.isWin = isWin;
            this.Time = Time;
        }
    }
}
