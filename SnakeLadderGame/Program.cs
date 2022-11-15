namespace SnakeLadderGame
{
    class Program
    {
        public static void Main(string[] args)
        {
            GameStart();

            int currrentPosition;

            CheckOption checkOption = new CheckOption();
            checkOption.CheckPosition();

            // for two player
            TwoPlayerGame twoPlayerGame = new TwoPlayerGame();
            twoPlayerGame.GameWinning();


        }
        public static void GameStart()
        {
            Console.WriteLine("welcome to game ladder and snake");
        }
    }
}
