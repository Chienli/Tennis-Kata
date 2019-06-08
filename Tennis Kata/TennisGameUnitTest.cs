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

            Assert.AreEqual(_tennisGame.GetResult(), GameState.Deuce.ToString());
        }

        [TestMethod]
        public void Deuce_two()
        {
            _tennisGame.SetPlayerScore(4, 4);

            Assert.AreEqual(_tennisGame.GetResult(), GameState.Deuce.ToString());
        }

        [TestMethod]
        public void Fifteen_All()
        {
            _tennisGame.SetPlayerScore(1, 1);

            Assert.AreEqual(_tennisGame.GetResult(), GameState.FifteenAll.ToString());
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            _tennisGame.SetPlayerScore(1, 0);

            Assert.AreEqual(_tennisGame.GetResult(), GameState.FifteenLove.ToString());
        }

        [TestMethod]
        public void Forty_Love()
        {
            _tennisGame.SetPlayerScore(3, 0);

            Assert.AreEqual(_tennisGame.GetResult(), GameState.FortyLove.ToString());
        }

        [TestMethod]
        public void Love_All()
        {
            _tennisGame.SetPlayerScore(0, 0);

            Assert.AreEqual(_tennisGame.GetResult(), GameState.LoveAll.ToString());
        }

        [TestMethod]
        public void Love_Fifteen()
        {
            _tennisGame.SetPlayerScore(0, 1);

            Assert.AreEqual(_tennisGame.GetResult(), GameState.LoveFifTeen.ToString());
        }

        [TestMethod]
        public void Love_Forty()
        {
            _tennisGame.SetPlayerScore(0, 3);

            Assert.AreEqual(_tennisGame.GetResult(), GameState.LoveForty.ToString());
        }

        [TestMethod]
        public void Love_Thirty()
        {
            _tennisGame.SetPlayerScore(0, 2);

            Assert.AreEqual(_tennisGame.GetResult(), GameState.LoveThirty.ToString());
        }

        [TestMethod]
        public void Thirty_All()
        {
            _tennisGame.SetPlayerScore(2, 2);

            Assert.AreEqual(_tennisGame.GetResult(), GameState.ThirtyAll.ToString());
        }

        [TestMethod]
        public void Thirty_Love()
        {
            _tennisGame.SetPlayerScore(2, 0);

            Assert.AreEqual(_tennisGame.GetResult(), GameState.ThirtyLove.ToString());
        }
    }
}