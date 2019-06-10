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
        private int _secondPlayerScore;

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
            if (_secondPlayerScore == 1)
            {
                return "Fifteen_Love";
            }
            if (_secondPlayerScore == 2)
            {
                return "Thirty_Love";
            }

            return "Love_All";
        }

        public void SecondPlayerGetPoint()
        {
            _secondPlayerScore++;
        }
    }
}