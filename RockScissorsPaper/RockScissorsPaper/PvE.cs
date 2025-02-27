namespace RockScissorsPaper
{
    internal class PvE
    {
        string userName = "";
        char usersChoice = '.';
        int computerRandom = 0;
        string computerChoice = "";
        string userChoiceSet = "";
        int computerPoints = 0;
        int userPoints = 0;
        int gameRound = 0;
        bool gameIsRunning = true;

        internal void gameOpening()
        {
            Console.Write("Welcome to Rock - Scissors - Paper\n"+
                              "The game ends if someone reach 3 points.\n" +
                              "User please enter your name here: ");
                userName = Console.ReadLine();
                Console.WriteLine($"Hello {userName}!");
        }

        internal void createRandomObject()
        {
            Random randomObject = new Random();

            computerRandom = randomObject.Next(1,4);

            if(computerRandom == 1)
            {
                computerChoice = "Rock";
            }
            if(computerRandom == 2)
            {
                computerChoice = "Scissors";
            }
            if (computerRandom == 3)
            {
                computerChoice = "Paper";
            }
        }

        internal void getUsersChoice()
        {
            Dictionary<char, string> choices = new Dictionary<char, string>
            {
                {'1', "Rock" },
                {'2',"Scissors" },
                {'3', "Paper" }
            };

            Console.WriteLine("Bitte wähle:\n(1) für 'Rock'\n(2) für 'Scissors'\n(3) für 'Paper'");
            char input = Console.ReadKey().KeyChar; //Reads an empty char without typing enter

            if (choices.ContainsKey(input))
            {
                userChoiceSet = choices[input];
            }
            else
            {
                Console.WriteLine("\nUngültige Eingabe! Bitte 1, 2 oder 3 wählen.");
                getUsersChoice(); // Repeats the input
            }
        }

        internal void checkWinner()
        {
            
            Console.WriteLine($"\nComputer choice is: {computerChoice} ");
            Console.WriteLine($"{userName} choice is: {userChoiceSet}");


            if(computerChoice == "Rock" && userChoiceSet == "Scissors")
            {
                computerPoints++;
                Console.WriteLine("Computer wins!");
            }
            else if(computerChoice == "Scissors" && userChoiceSet == "Paper")
            {
                computerPoints++;
                Console.WriteLine("Computer wins!");
            }
            else if(computerChoice == "Paper" && userChoiceSet == "Rock")
            {
                computerPoints++;
                Console.WriteLine("Computer wins!");
            } 
            else if(computerChoice == userChoiceSet)
            {
                Console.WriteLine("Draw!");
            }
            else
            {
                userPoints++;
                Console.WriteLine($"{userName} wins!");
            }

            Console.WriteLine("Standings:\n"+
                             $"Computer: {computerPoints}\n"+
                             $"{userName}: {userPoints}");

            if(computerPoints == 3)
            {
                Console.WriteLine("Computer win the game!");
                gameIsRunning = false;
            }
            else if(userPoints == 3)
            {
                Console.WriteLine($"{userName} win the game!");
                gameIsRunning = false;
            }
            else
            {
                Console.WriteLine("Game on.");
            }
        } 

        internal void runGame()
        {
            gameOpening();
            while(computerPoints < 3 || userPoints < 3)
            {
                createRandomObject();
                getUsersChoice();
                checkWinner();
                if(computerPoints == 3 || userPoints == 3)
                {
                    break;
                }
            }
        }
    }
}
