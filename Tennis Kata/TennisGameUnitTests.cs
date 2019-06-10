using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tennis_Kata
{
    public class TennisGame
    {
        public string Score()
        {
            return "Love_All";
        }
    }

    [TestClass]
    public class TennisGameUnitTests
    {
        private readonly TennisGame _tennis = new TennisGame();

        [TestMethod]
        public void Love_All()
        {
            Assert.AreEqual("Love_All", _tennis.Score());
        }
    }
}