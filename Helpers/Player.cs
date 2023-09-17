namespace Deliverable2.Helpers
{
    public class Player
    {
        public string? name;
        public string? answer;
        public string? choice;

        bool validAnswer;

        public void SetPlayersName()
        {
            Console.WriteLine("What is your name?");

            while (validAnswer == false)
            {
                name = Console.ReadLine();

                Console.WriteLine();

                if (name == "")
                {
                    Console.WriteLine("Enter a valid name.");
                }
                else { validAnswer = true; };

            }

            validAnswer = false;

        }

        public void GameInvite()
        {
            Console.WriteLine($"Welcome {name}. Do you want to do the Coin Flip Challenge? Yes/No");

            while (validAnswer == false)
            {
                answer = Console.ReadLine()?.ToLower();

                Console.WriteLine();

                if (answer != "no" && answer != "yes")
                {
                    Console.WriteLine("Enter Yes or No only.");
                }
                else { validAnswer = true; };

            }

            validAnswer = false;

        }

        public void GetPlayersChoice() {

            Console.WriteLine("Heads or Tails");

            while (validAnswer == false)
            {
                choice = Console.ReadLine()?.ToLower();

                Console.WriteLine();

                if (choice != "heads" && choice != "tails")
                {
                    Console.WriteLine("Enter Heads or Tails only.");
                }

                else { validAnswer = true; };
            
            }
        
            validAnswer = false;

        }
        
    }

}
