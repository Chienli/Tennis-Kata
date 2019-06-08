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

            Assert.AreEqual(_tennisGame.GetResult(), "Deuce");
        }

        [TestMethod]
        public void Deuce_two()
        {
            _tennisGame.SetPlayerScore(4, 4);

            Assert.AreEqual(_tennisGame.GetResult(), "Deuce");
        }

        [TestMethod]
        public void Fifteen_All()
        {
            _tennisGame.SetPlayerScore(1, 1);

            Assert.AreEqual(_tennisGame.GetResult(), "Fifteen-All");
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            _tennisGame.SetPlayerScore(1, 0);

            Assert.AreEqual(_tennisGame.GetResult(), "Fifteen-Love");
        }

        [TestMethod]
        public void Forty_Love()
        {
            _tennisGame.SetPlayerScore(3, 0);

            Assert.AreEqual(_tennisGame.GetResult(), "Forty-Love");
        }

        [TestMethod]
        public void Love_All()
        {
            _tennisGame.SetPlayerScore(0, 0);

            Assert.AreEqual(_tennisGame.GetResult(), "Love-All");
        }

        [TestMethod]
        public void Love_Fifteen()
        {
            _tennisGame.SetPlayerScore(0, 1);

            Assert.AreEqual(_tennisGame.GetResult(), "Love-Fifteen");
        }

        [TestMethod]
        public void Love_Forty()
        {
            _tennisGame.SetPlayerScore(0, 3);

            Assert.AreEqual(_tennisGame.GetResult(), "Love-Forty");
        }

        [TestMethod]
        public void Love_Thirty()
        {
            _tennisGame.SetPlayerScore(0, 2);

            Assert.AreEqual(_tennisGame.GetResult(), "Love-Thirty");
        }

        [TestMethod]
        public void Thirty_All()
        {
            _tennisGame.SetPlayerScore(2, 2);

            Assert.AreEqual(_tennisGame.GetResult(), "Thirty-All");
        }

        [TestMethod]
        public void Thirty_Love()
        {
            _tennisGame.SetPlayerScore(2, 0);

            Assert.AreEqual(_tennisGame.GetResult(), "Thirty-Love");
        }
    }
}