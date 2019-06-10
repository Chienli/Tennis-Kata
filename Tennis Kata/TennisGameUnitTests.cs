using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tennis_Kata
{
    [TestClass]
    public class TennisGameUnitTests
    {
        private readonly TennisGame _tennis = new TennisGame();

        [TestMethod]
        public void Deuce()
        {
            FirstPlayerGetTimesPoints(3);
            SecondPlayerGetTimesPoints(3);
            Assert.AreEqual("Deuce", _tennis.Score());
        }

        [TestMethod]
        public void Fifteen_All()
        {
            FirstPlayerGetTimesPoints(1);
            SecondPlayerGetTimesPoints(1);
            Assert.AreEqual("Fifteen_All", _tennis.Score());
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            FirstPlayerGetTimesPoints(1);

            Assert.AreEqual("Fifteen_Love", _tennis.Score());
        }

        [TestMethod]
        public void FirstPlayer_Advance()
        {
            FirstPlayerGetTimesPoints(4);
            SecondPlayerGetTimesPoints(3);
            Assert.AreEqual("Guy_Adv", _tennis.Score());
        }

        [TestMethod]
        public void Forty_Love()
        {
            FirstPlayerGetTimesPoints(3);

            Assert.AreEqual("Forty_Love", _tennis.Score());
        }

        [TestMethod]
        public void Love_All()
        {
            Assert.AreEqual("Love_All", _tennis.Score());
        }

        [TestMethod]
        public void Love_Fifteen()
        {
            SecondPlayerGetTimesPoints(1);
            Assert.AreEqual("Love_Fifteen", _tennis.Score());
        }

        [TestMethod]
        public void Love_Forty()
        {
            SecondPlayerGetTimesPoints(3);

            Assert.AreEqual("Love_Forty", _tennis.Score());
        }

        [TestMethod]
        public void Love_Thirty()
        {
            SecondPlayerGetTimesPoints(2);

            Assert.AreEqual("Love_Thirty", _tennis.Score());
        }

        [TestMethod]
        public void Thirty_All()
        {
            FirstPlayerGetTimesPoints(2);
            SecondPlayerGetTimesPoints(2);
            Assert.AreEqual("Thirty_All", _tennis.Score());
        }

        [TestMethod]
        public void Thirty_Love()
        {
            FirstPlayerGetTimesPoints(2);

            Assert.AreEqual("Thirty_Love", _tennis.Score());
        }

        private void FirstPlayerGetTimesPoints(int times)
        {
            for (var i = 0; i < times; i++)
            {
                _tennis.FirstPlayerGetPoint();
            }
        }

        private void SecondPlayerGetTimesPoints(int times)
        {
            for (var i = 0; i < times; i++)
            {
                _tennis.SecondPlayerGetPoint();
            }
        }
    }
}