using System;

namespace TankGame
{
    class StatisticUser
    {
        public string NickNameEnemy;
        public TimeSpan MatchLength;
        public bool IsWin;
        public StatisticUser()
        {
            NickNameEnemy = String.Empty;
            MatchLength = new TimeSpan();
            IsWin = false;
        }

        public StatisticUser(string NickNameEnemy,TimeSpan MatchLength,bool IsWin)
        {
            this.NickNameEnemy = NickNameEnemy;
            this.MatchLength = MatchLength;
            this.IsWin = IsWin;
        }
    }
}
