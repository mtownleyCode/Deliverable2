using Deliverable2.Helpers;
using System.Diagnostics.Metrics;

namespace Deliverable2.Scoring
{
    public class ScoreFlip
    {
        int score;

        public bool win;

        public Dictionary<int, string> possibleScores = new Dictionary<int, string>(){
            {0, "heads"},
            {1, "tails"},
        };
       
        public void ScoreCoinFlip(int attempt, int flipResult, Player player)
        {
            win = possibleScores.FirstOrDefault(pair => pair.Key == flipResult).Value == player.choice;

            if (win)
            {
                Console.WriteLine("Congratulations You Won!");
                score++;

                if (attempt < 5)
                {
                    Console.WriteLine($"Your score is now { score } / { attempt }");
                    Console.WriteLine();
                }
                else
                {
                    FinalScoreMessage(attempt, player); 
                }

            }
            else
            {
                Console.WriteLine("Sorry, you lost.");

                if (attempt < 5)
                {
                    Console.WriteLine($"Your score is still {score} / {attempt}");
                    Console.WriteLine();
                }
                else
                {
                    FinalScoreMessage(attempt, player);
                }
            
            }

        }

        public void FinalScoreMessage(int attempt, Player player)
        {
            Console.WriteLine();

            switch (score)
            {
                case 1:
                    
                    Console.WriteLine($"Thank you {player.name}. Your final score is {score} / {attempt}.");
                    Console.WriteLine("There is no need for you to be gambling.");
                    break;

                case 2:

                    Console.WriteLine($"Thank you {player.name}. Your final score is {score} / {attempt}.");
                    Console.WriteLine("Better luck next time.");
                    break;

                case 3:

                    Console.WriteLine($"Thank you {player.name}. Your final score is {score} / {attempt}.");
                    Console.WriteLine("Better than 50%, not too bad.");
                    break;

                case 4:

                    Console.WriteLine($"Thank you {player.name}. Your final score is {score} / {attempt}.");
                    Console.WriteLine("You are on fire!");
                    break;

                case 5:

                    Console.WriteLine($"Thank you {player.name}. Your final score is {score} / {attempt}.");
                    Console.WriteLine("Wow! Run as fast as you can and buy a lottery ticket.");
                    break;
            }

        }

    }

}
