namespace RockScissorsPaper
{
    internal class PvP
    {
        string playerOne = "";
        string playerTwo = "";
        string playerOneChoice = "";
        string playerTwoChoice = "";
        int playerOnePoints = 0;
        int playerTwoPoints = 0;
        bool gameIsRunning = true;

        internal void gameOpening()
        {
            Console.Write("Welcome to Rock - Scissors - Paper\n" +
                              "The game ends if someone reach 3 points.\n" +
                              "User One please enter your name here: ");
            playerOne = Console.ReadLine();
            Console.WriteLine($"Hello {playerOne}!");

            Console.Write("User Two please enter your name here: ");
            playerTwo = Console.ReadLine();
            Console.WriteLine($"Hello {playerTwo}!");
        }

        internal void userChoices()
        {
            Dictionary<char, string> choices = new Dictionary<char, string>
            {
                {'1', "Rock"},
                {'2', "Scissors"},
                {'3', "Paper"}
            };

            Console.WriteLine($"{playerOne}, bitte wähle:\n(1) für 'Rock'\n(2) für 'Scissors'\n(3) für 'Paper'");
            char inputOne = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Linebreak for a better readability

            Console.WriteLine($"{playerTwo}, bitte wähle:\n(1) für 'Rock'\n(2) für 'Scissors'\n(3) für 'Paper'");
            char inputTwo = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if(choices.ContainsKey(inputOne) && choices.ContainsKey(inputTwo))
            {
                playerOneChoice = choices[inputOne];
                playerTwoChoice = choices[inputTwo];
                Console.WriteLine($"{playerOne} hat gewählt: {playerOneChoice}");
                Console.WriteLine($"{playerTwo} hat gewählt: {playerTwoChoice}");
            }
            else
            {
                Console.WriteLine("\nUngültige Eingabe! Bitte nur 1, 2 oder 3 wählen.");
                userChoices(); // Wiederhole die Eingabe für beide Spieler
            }
        }

        internal void checkWinner()
        {

            Console.WriteLine($"{playerOne} choice is: {playerOneChoice} ");
            Console.WriteLine($"{playerTwo} choice is: {playerTwoChoice}");


            if (playerOneChoice == "Rock" && playerTwoChoice == "Scissors")
            {
                playerOnePoints++;
                Console.WriteLine($"{playerOne} wins!");
            }
            else if (playerOneChoice == "Scissors" && playerTwoChoice == "Paper")
            {
                playerOnePoints++;
                Console.WriteLine($"{playerOne} wins!");
            }
            else if (playerOneChoice == "Paper" && playerTwoChoice == "Rock")
            {
                playerOnePoints++;
                Console.WriteLine($"{playerOne} wins!");
            }
            else if (playerOneChoice == playerTwoChoice)
            {
                Console.WriteLine("Draw!");
            }
            else
            {
                playerTwoPoints++;
                Console.WriteLine($"{playerTwo} wins!");
            }

            Console.WriteLine("Standings:\n" +
                             $"{playerOne}: {playerOnePoints}\n" +
                             $"{playerTwo}: {playerTwoPoints}");

            if (playerOnePoints == 3)
            {
                Console.WriteLine($"{playerOne} win the game!");
                gameIsRunning = false;
            }
            else if (playerTwoPoints == 3)
            {
                Console.WriteLine($"{playerTwo} win the game!");
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
            while(playerOnePoints < 3 && playerTwoPoints < 3)
            {
                userChoices();
                checkWinner();
                if(playerOnePoints == 3 || playerTwoPoints == 3)
                {
                    break;
                }
            }
        }
    }
}
