namespace ForestClearing;

internal static class Program
{
    private static void Main()
    {
        ForegroundColor = ConsoleColor.Green;

        ForestClearing.Main.Intro();
        //string? playerName = MainMethod.PlayerName();

        Map.Clearing();
    }
}