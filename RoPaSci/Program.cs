using System;

namespace RoPaSci
{
    class Program
    {
        static void Main(string[] args)
        {
            string player1Input = "Rock";
            string player2Input = "Paper";

            GameItem player1 = Enum.Parse<GameItem>(player1Input);
            GameItem player2 = Enum.Parse<GameItem>(player2Input);

            GameStatus result = RockPaperScissors(player1, player2);
            Console.WriteLine($"Result: {result}");
        }
        private static GameStatus RockPaperScissors(GameItem player1, GameItem player2)
        {
            if (player1 == player2)
                return GameStatus.Draw;
            switch (player1)
            {
                case GameItem.Rock:
                    return (player2 == GameItem.Scissors) ? GameStatus.Player1Wins : GameStatus.Player2Wins;
                case GameItem.Paper:
                    return (player2 == GameItem.Rock) ? GameStatus.Player1Wins : GameStatus.Player2Wins;
                case GameItem.Scissors:
                    return (player2 == GameItem.Paper) ? GameStatus.Player1Wins : GameStatus.Player2Wins;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
