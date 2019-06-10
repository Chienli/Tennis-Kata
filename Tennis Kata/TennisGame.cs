using System.Collections.Generic;

namespace Tennis_Kata
{
    public class TennisGame
    {
        private readonly Dictionary<int, string> _scoreLookUp = new Dictionary<int, string>
        {
            {0,"Love"},
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
            if (_firstPlayerScore != _secondPlayerScore)
            {
                return $"{_scoreLookUp[_firstPlayerScore]}_{_scoreLookUp[_secondPlayerScore]}";
            }

            return "Love_All";
        }

        public void SecondPlayerGetPoint()
        {
            _secondPlayerScore++;
        }
    }
}