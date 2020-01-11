namespace NewGameTemplate
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Bootstrap.Initialize_FNA();
            using var game = new NewGame();
            game.Run();
        }
    }
}