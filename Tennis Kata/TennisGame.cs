using System;
using System.Collections.Generic;

namespace Tennis_Kata
{
    public class TennisGame
    {
        private readonly string _firstPlayerName;

        private readonly Dictionary<int, string> _scoreLookUp = new Dictionary<int, string>
        {
            {0,"Love"},
            {1,"Fifteen"},
            {2,"Thirty"},
            {3,"Forty"}
        };

        private readonly string _secondPlayerName;
        private int _firstPlayerScore;
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
                return IsDeuce() ? "Deuce" : $"{_scoreLookUp[_firstPlayerScore]}_All";
            }
            else
            {
                if (IsGamePoint())
                {
                    return IsAdvance() ? $"{GetAdvanceName()}_Adv" : $"{GetAdvanceName()}_Win";
                }

                return $"{_scoreLookUp[_firstPlayerScore]}_{_scoreLookUp[_secondPlayerScore]}";
            }
        }

        public void SecondPlayerGetPoint()
        {
            _secondPlayerScore++;
        }

        private string GetAdvanceName()
        {
            var advanceName = _firstPlayerScore > _secondPlayerScore ? _firstPlayerName : _secondPlayerName;

            return advanceName;
        }

        private bool IsAdvance()
        {
            return Math.Abs(_firstPlayerScore - _secondPlayerScore) == 1;
        }

        private bool IsDeuce()
        {
            return _firstPlayerScore >= 3;
        }

        private bool IsGamePoint()
        {
            return _firstPlayerScore > 3 || _secondPlayerScore > 3;
        }

        private bool IsSame()
        {
            return _firstPlayerScore == _secondPlayerScore;
        }
    }
}