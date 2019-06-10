using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tennis_Kata
{
    [TestClass]
    public class TennisGameUnitTest
    {
        private readonly TennisGame _tennisGame = new TennisGame();

        [TestMethod]
        public void Deuce_one()
        {
            _tennisGame.SetPlayerScore(3, 3);

            Assert.AreEqual(GameState.Deuce.ToString(), _tennisGame.GetResult());
        }

        [TestMethod]
        public void Deuce_two()
        {
            _tennisGame.SetPlayerScore(4, 4);

            Assert.AreEqual(GameState.Deuce.ToString(), _tennisGame.GetResult());
        }

        [TestMethod]
        public void Fifteen_All()
        {
            _tennisGame.SetPlayerScore(1, 1);

            Assert.AreEqual(GameState.FifteenAll.ToString(), _tennisGame.GetResult());
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            _tennisGame.SetPlayerScore(1, 0);

            Assert.AreEqual(GameState.FifteenLove.ToString(), _tennisGame.GetResult());
        }

        [TestMethod]
        public void FirstPlayer_Advance()
        {
            _tennisGame.SetPlayerScore(4, 3);

            var expected = _tennisGame.FirstPlayer.Name + GameState.Advance.ToString();

            Assert.AreEqual(expected, _tennisGame.GetResult());
        }

        [TestMethod]
        public void FirstPlayer_Win()
        {
            _tennisGame.SetPlayerScore(5, 3);

            var expected = _tennisGame.FirstPlayer.Name + GameState.Win.ToString();

            Assert.AreEqual(expected, _tennisGame.GetResult());
        }

        [TestMethod]
        public void Forty_Love()
        {
            _tennisGame.SetPlayerScore(3, 0);

            Assert.AreEqual(GameState.FortyLove.ToString(), _tennisGame.GetResult());
        }

        [TestMethod]
        public void Love_All()
        {
            _tennisGame.SetPlayerScore(0, 0);

            Assert.AreEqual(GameState.LoveAll.ToString(), _tennisGame.GetResult());
        }

        [TestMethod]
        public void Love_Fifteen()
        {
            _tennisGame.SetPlayerScore(0, 1);

            Assert.AreEqual(GameState.LoveFifTeen.ToString(), _tennisGame.GetResult());
        }

        [TestMethod]
        public void Love_Forty()
        {
            _tennisGame.SetPlayerScore(0, 3);

            Assert.AreEqual(GameState.LoveForty.ToString(), _tennisGame.GetResult());
        }

        [TestMethod]
        public void Love_Thirty()
        {
            _tennisGame.SetPlayerScore(0, 2);

            Assert.AreEqual(GameState.LoveThirty.ToString(), _tennisGame.GetResult());
        }

        [TestMethod]
        public void SecondPlayer_Advance()
        {
            _tennisGame.SetPlayerScore(3, 4);

            var expected = _tennisGame.SecondPlayer.Name + GameState.Advance.ToString();

            Assert.AreEqual(expected, _tennisGame.GetResult());
        }

        [TestMethod]
        public void SecondPlayer_Win()
        {
            _tennisGame.SetPlayerScore(3, 5);

            var expected = _tennisGame.SecondPlayer.Name + GameState.Win.ToString();

            Assert.AreEqual(expected, _tennisGame.GetResult());
        }

        [TestMethod]
        public void Thirty_All()
        {
            _tennisGame.SetPlayerScore(2, 2);

            Assert.AreEqual(GameState.ThirtyAll.ToString(), _tennisGame.GetResult());
        }

        [TestMethod]
        public void Thirty_Love()
        {
            _tennisGame.SetPlayerScore(2, 0);

            Assert.AreEqual(GameState.ThirtyLove.ToString(), _tennisGame.GetResult());
        }
    }
}