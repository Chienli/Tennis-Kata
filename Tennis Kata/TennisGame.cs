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

            return "Love_All";
        }
    }
}