using System.Runtime.InteropServices;

namespace Tennis_Kata
{
    public class TennisGame
    {
        public Player FirstPlayer = new Player("guy", 0);
        public Player SecondPlayer = new Player("jay", 0);

        public string GetResult()
        {
            var result = "";
            switch (FirstPlayer.Score)
            {
                case 0 when SecondPlayer.Score == 0:
                    result = GameState.LoveAll.ToString();
                    break;

                case 1 when SecondPlayer.Score == 0:
                    result = GameState.FifteenLove.ToString();
                    break;

                case 2 when SecondPlayer.Score == 0:
                    result = GameState.ThirtyLove.ToString();
                    break;

                case 3 when SecondPlayer.Score == 0:
                    result = GameState.FortyLove.ToString();
                    break;

                case 0 when SecondPlayer.Score == 1:
                    result = GameState.LoveFifTeen.ToString();
                    break;

                case 0 when SecondPlayer.Score == 2:
                    result = GameState.LoveThirty.ToString();
                    break;

                case 0 when SecondPlayer.Score == 3:
                    result = GameState.LoveForty.ToString();
                    break;

                case 1 when SecondPlayer.Score == 1:
                    result = GameState.FifteenAll.ToString();
                    break;

                case 2 when SecondPlayer.Score == 2:
                    result = GameState.ThirtyAll.ToString();
                    break;

                case 3 when SecondPlayer.Score == 3:
                case 4 when SecondPlayer.Score == 4:
                    result = GameState.Deuce.ToString();
                    break;

                case 4 when SecondPlayer.Score == 3:
                    result = FirstPlayer.Name + GameState.Advance.ToString();
                    break;

                case 3 when SecondPlayer.Score == 4:
                    result = SecondPlayer.Name + GameState.Advance.ToString();
                    break;

                case 5 when SecondPlayer.Score == 3:
                    result = FirstPlayer.Name + GameState.Win.ToString();
                    break;

                case 3 when SecondPlayer.Score == 5:
                    result = SecondPlayer.Name + GameState.Win.ToString();
                    break;
            }

            return result;
        }

        public void SetPlayerScore(int firstScore, int secondScore)
        {
            FirstPlayer.Score = firstScore;
            SecondPlayer.Score = secondScore;
        }
    }
}