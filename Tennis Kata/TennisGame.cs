using System;
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

        private string _firstPlayerName;
        private int _firstPlayerScore;
        private string _secondPlayerName;
        private int _secondPlayerScore;

        public TennisGame(string firstPlayerName, string secondPlayerName)
        {
            _firstPlayerName = firstPlayerName;
            _secondPlayerName = secondPlayerName;
        }

        public void FirstPlayerGetPoint()
        {
            _firstPlayerScore++;
        }

        public string Score()
        {
            if (IsSame())
            {
                if (_firstPlayerScore >= 3)
                {
                    return "Deuce";
                }

                return $"{_scoreLookUp[_firstPlayerScore]}_All";
            }
            else
            {
                if (_firstPlayerScore > 3 || _secondPlayerScore > 3)
                {
                    if (Math.Abs(_firstPlayerScore - _secondPlayerScore) == 1)
                    {
                        if (_firstPlayerScore > _secondPlayerScore)
                        {
                            return $"{_firstPlayerName}_Adv";
                        }

                        return $"{_secondPlayerName}_Adv";
                    }

                    if (_firstPlayerScore > _secondPlayerScore)
                    {
                        return $"{_firstPlayerName}_Win";
                    }
                }

                return $"{_scoreLookUp[_firstPlayerScore]}_{_scoreLookUp[_secondPlayerScore]}";
            }
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