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
            if (IsSame())
            {
                if (_firstPlayerScore >= 3 && _secondPlayerScore >= 3)
                {
                    return "Deuce";
                }

                return $"{_scoreLookUp[_firstPlayerScore]}_All";
            }
            return $"{_scoreLookUp[_firstPlayerScore]}_{_scoreLookUp[_secondPlayerScore]}";
        }

        public void SecondPlayerGetPoint()
        {
            _secondPlayerScore++;
        }

        private bool IsSame()
        {
            return _firstPlayerScore == _secondPlayerScore;
        }
    }
}