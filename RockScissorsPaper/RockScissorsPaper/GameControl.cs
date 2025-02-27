namespace RockScissorsPaper
{
    internal class GameControl
    {
        internal void gameSetup()
        {
            bool gameIsStopped = false;
            bool gameAgainstEnvironment = false;
            bool gameAgainstPlayer = false;
            PvE pve = new PvE();
            PvP pvp = new PvP();

            while (!gameIsStopped)
            {
                Console.WriteLine("Do you want to play against the computer or against a friend?\n" +
                  "(1) Computer\n" +
                  "(2) Friend\n" +
                  "(3) to end the game");
                string gameSetting = Console.ReadLine();

                if (gameSetting == "1")
                {
                    pve.runGame();

                }
                else if (gameSetting == "2")
                {
                    pvp.runGame();
                }
                else if (gameSetting == "3")
                {
                    gameIsStopped = true;
                }
                else
                {
                    Console.WriteLine("Choose a correct number");
                }
            }
            
        }
    }
}
