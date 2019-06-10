namespace Tennis_Kata
{
    public class TennisGame
    {
        private int _firstPlayerScore;

        public void FirstPlayerGetPoint()
        {
            _firstPlayerScore++;
        }

        public string Score()
        {
            if (_firstPlayerScore == 1)
            {
                return "Love_Fifteen";
            }
            if (_firstPlayerScore == 2)
            {
                return "Love_Thirty";
            }
            if (_firstPlayerScore == 3)
            {
                return "Love_Forty";
            }

            return "Love_All";
        }
    }
}