using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tennis_Kata
{
    [TestClass]
    public class TennisGameUnitTests
    {
        private readonly TennisGame _tennis = new TennisGame("Guy", "Jay");

        [TestMethod]
        public void Deuce()
        {
            FirstPlayerGetTimesPoints(3);
            SecondPlayerGetTimesPoints(3);

            ScoreShouldBe("Deuce");
        }

        [TestMethod]
        public void Fifteen_All()
        {
            FirstPlayerGetTimesPoints(1);
            SecondPlayerGetTimesPoints(1);

            ScoreShouldBe("Fifteen_All");
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            FirstPlayerGetTimesPoints(1);

            ScoreShouldBe("Fifteen_Love");
        }

        [TestMethod]
        public void FirstPlayer_Advance()
        {
            FirstPlayerGetTimesPoints(4);
            SecondPlayerGetTimesPoints(3);

            ScoreShouldBe("Guy_Adv");
        }

        [TestMethod]
        public void FirstPlayer_Win()
        {
            FirstPlayerGetTimesPoints(5);
            SecondPlayerGetTimesPoints(3);

            ScoreShouldBe("Guy_Win");
        }

        [TestMethod]
        public void Forty_Love()
        {
            FirstPlayerGetTimesPoints(3);

            ScoreShouldBe("Forty_Love");
        }

        [TestMethod]
        public void Love_All()
        {
            ScoreShouldBe("Love_All");
        }

        [TestMethod]
        public void Love_Fifteen()
        {
            SecondPlayerGetTimesPoints(1);

            ScoreShouldBe("Love_Fifteen");
        }

        [TestMethod]
        public void Love_Forty()
        {
            SecondPlayerGetTimesPoints(3);

            ScoreShouldBe("Love_Forty");
        }

        [TestMethod]
        public void Love_Thirty()
        {
            SecondPlayerGetTimesPoints(2);

            ScoreShouldBe("Love_Thirty");
        }

        [TestMethod]
        public void SecondPlayer_Advance()
        {
            FirstPlayerGetTimesPoints(3);
            SecondPlayerGetTimesPoints(4);

            ScoreShouldBe("Jay_Adv");
        }

        [TestMethod]
        public void SecondPlayer_Win()
        {
            FirstPlayerGetTimesPoints(3);
            SecondPlayerGetTimesPoints(5);

            ScoreShouldBe("Jay_Win");
        }

        [TestMethod]
        public void Thirty_All()
        {
            FirstPlayerGetTimesPoints(2);
            SecondPlayerGetTimesPoints(2);

            ScoreShouldBe("Thirty_All");
        }

        [TestMethod]
        public void Thirty_Love()
        {
            FirstPlayerGetTimesPoints(2);

            ScoreShouldBe("Thirty_Love");
        }

        private void FirstPlayerGetTimesPoints(int times)
        {
            for (var i = 0; i < times; i++)
            {
                _tennis.FirstPlayerGetPoint();
            }
        }

        private void ScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, _tennis.Score());
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