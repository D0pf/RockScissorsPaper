namespace RockScissorsPaper
{
    internal class Program : GameControl
    {
        static void Main(string[] args)
        {
            GameControl gameControl = new GameControl();
            gameControl.gameSetup();
        }
    }
}
