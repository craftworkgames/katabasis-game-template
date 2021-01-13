namespace MyGame
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            using var game = new MyGame();
            game.Run();
        }
    }
}
