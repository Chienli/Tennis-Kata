namespace Tennis_Kata
{
    public class TennisGame
    {
        public int TheScoreOfFirstPlayer { get; set; }
        public int TheScoreOfSecondPlayer { get; set; }

        public string GetResult()
        {
            var result = "";
            switch (TheScoreOfFirstPlayer)
            {
                case 0 when TheScoreOfSecondPlayer == 0:
                    result = "Love-All";
                    break;

                case 1 when TheScoreOfSecondPlayer == 0:
                    result = "Fifteen-Love";
                    break;

                case 2 when TheScoreOfSecondPlayer == 0:
                    result = "Thirty-Love";
                    break;

                case 3 when TheScoreOfSecondPlayer == 0:
                    result = "Forty-Love";
                    break;

                case 0 when TheScoreOfSecondPlayer == 1:
                    result = "Love-Fifteen";
                    break;

                case 0 when TheScoreOfSecondPlayer == 2:
                    result = "Love-Thirty";
                    break;

                case 0 when TheScoreOfSecondPlayer == 3:
                    result = "Love-Forty";
                    break;

                case 1 when TheScoreOfSecondPlayer == 1:
                    result = "Fifteen-All";
                    break;

                case 2 when TheScoreOfSecondPlayer == 2:
                    result = "Thirty-All";
                    break;

                case 3 when TheScoreOfSecondPlayer == 3:
                case 4 when TheScoreOfSecondPlayer == 4:
                    result = "Deuce";
                    break;
            }

            return result;
        }

        public void SetPlayerScore(int firstScore, int secondScore)
        {
            TheScoreOfFirstPlayer = firstScore;
            TheScoreOfSecondPlayer = secondScore;
        }
    }
}