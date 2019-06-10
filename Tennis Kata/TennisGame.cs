using System.Collections.Generic;

namespace Tennis_Kata
{
    public class TennisGame
    {
        private readonly Dictionary<int, string> _scoreLookUp = new Dictionary<int, string>
        {
            {1,"Fifteen"},
            {2,"Thirty"},
            {3,"Forty"}
        };

        private int _firstPlayerScore;

        public void FirstPlayerGetPoint()
        {
            _firstPlayerScore++;
        }

        public string Score()
        {
            if (_firstPlayerScore != 0)
            {
                return $"Love_{_scoreLookUp[_firstPlayerScore]}";
            }

            return "Love_All";
        }
    }
}