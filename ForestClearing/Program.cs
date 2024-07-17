namespace ForestClearing;

internal static class Program
{
    private static void Main()
    {
        ForegroundColor = ConsoleColor.Green;

        ForestClearing.Main.Intro();
        string? playerName = ForestClearing.Main.PlayerName();

        Map.Clearing();
    }
}