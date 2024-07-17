namespace ForestClearing;

internal static class Program
{
    private static void Main()
    {
        ForegroundColor = ConsoleColor.Green;

        MainMethod.Intro();
        //string? playerName = MainMethod.PlayerName();

        Map.Clearing();
    }
}