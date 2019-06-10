using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tennis_Kata
{
    [TestClass]
    public class TennisGameUnitTests
    {
        private readonly TennisGame _tennis = new TennisGame();

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
        public void Love_Thirty()
        {
            _tennis.FirstPlayerGetPoint();
            _tennis.FirstPlayerGetPoint();

            Assert.AreEqual("Love_Thirty", _tennis.Score());
        }
    }
}