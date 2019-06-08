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
                    result = GameState.LoveAll.ToString();
                    break;

                case 1 when TheScoreOfSecondPlayer == 0:
                    result = GameState.FifteenLove.ToString();
                    break;

                case 2 when TheScoreOfSecondPlayer == 0:
                    result = GameState.ThirtyLove.ToString();
                    break;

                case 3 when TheScoreOfSecondPlayer == 0:
                    result = GameState.FortyLove.ToString();
                    break;

                case 0 when TheScoreOfSecondPlayer == 1:
                    result = GameState.LoveFifTeen.ToString();
                    break;

                case 0 when TheScoreOfSecondPlayer == 2:
                    result = GameState.LoveThirty.ToString();
                    break;

                case 0 when TheScoreOfSecondPlayer == 3:
                    result = GameState.LoveForty.ToString();
                    break;

                case 1 when TheScoreOfSecondPlayer == 1:
                    result = GameState.FifteenAll.ToString();
                    break;

                case 2 when TheScoreOfSecondPlayer == 2:
                    result = GameState.ThirtyAll.ToString();
                    break;

                case 3 when TheScoreOfSecondPlayer == 3:
                case 4 when TheScoreOfSecondPlayer == 4:
                    result = GameState.Deuce.ToString();
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