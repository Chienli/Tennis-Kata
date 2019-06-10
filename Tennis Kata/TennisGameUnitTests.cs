using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tennis_Kata
{
    [TestClass]
    public class TennisGameUnitTests
    {
        private readonly TennisGame _tennis = new TennisGame();

        [TestMethod]
        public void Fifteen_Love()
        {
            _tennis.SecondPlayerGetPoint();

            Assert.AreEqual("Fifteen_Love", _tennis.Score());
        }

        [TestMethod]
        public void Forty_Love()
        {
            SecondPlayerGetTimesPoints(3);

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
            _tennis.FirstPlayerGetPoint();
            Assert.AreEqual("Love_Fifteen", _tennis.Score());
        }

        [TestMethod]
        public void Love_Forty()
        {
            FirstPlayerGetTimesPoints(3);

            Assert.AreEqual("Love_Forty", _tennis.Score());
        }

        [TestMethod]
        public void Love_Thirty()
        {
            FirstPlayerGetTimesPoints(2);

            Assert.AreEqual("Love_Thirty", _tennis.Score());
        }

        [TestMethod]
        public void Thirty_Love()
        {
            SecondPlayerGetTimesPoints(2);

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