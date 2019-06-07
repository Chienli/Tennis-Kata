using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tennis_Kata
{
    public class TennisGame
    {
        public int TheScoreOfFirstPlayer { get; set; }
        public int TheScoreOfSecondPlayer { get; set; }

        public string GetResult()
        {
            var result = "";
            switch (TheScoreOfFirstPlayer)
            {
                case 0 when TheScoreOfSecondPlayer == 0:
                    result = "Love-All";
                    break;

                case 1 when TheScoreOfSecondPlayer == 0:
                    result = "Fifteen-Love";
                    break;

                case 2 when TheScoreOfSecondPlayer == 0:
                    result = "Thirty-Love";
                    break;

                case 3 when TheScoreOfSecondPlayer == 0:
                    result = "Forty-Love";
                    break;
            }

            return result;
        }
    }

    [TestClass]
    public class TennisGameUnitTest
    {
        private readonly TennisGame _tennisGame = new TennisGame();

        [TestMethod]
        public void Fifteen_Love()
        {
            _tennisGame.TheScoreOfFirstPlayer = 1;
            _tennisGame.TheScoreOfSecondPlayer = 0;

            Assert.AreEqual(_tennisGame.GetResult(), "Fifteen-Love");
        }

        [TestMethod]
        public void Forty_Love()
        {
            _tennisGame.TheScoreOfFirstPlayer = 3;
            _tennisGame.TheScoreOfSecondPlayer = 0;

            Assert.AreEqual(_tennisGame.GetResult(), "Forty-Love");
        }

        [TestMethod]
        public void Love_All()
        {
            _tennisGame.TheScoreOfFirstPlayer = 0;
            _tennisGame.TheScoreOfSecondPlayer = 0;

            Assert.AreEqual(_tennisGame.GetResult(), "Love-All");
        }

        [TestMethod]
        public void Thirty_Love()
        {
            _tennisGame.TheScoreOfFirstPlayer = 2;
            _tennisGame.TheScoreOfSecondPlayer = 0;

            Assert.AreEqual(_tennisGame.GetResult(), "Thirty-Love");
        }
    }
}