namespace ForestClearing;

internal static class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        //INTRO

        MainMethod.Intro();
        string? playerName = MainMethod.PlayerName();

        Map.Clearing();

        int x = 0;
        int y = 0;

        //string input = Console.ReadLine();
        //if (input == "south")
        //{
        //    x -= 1;
        //    Map.PlayerLocation(x, y);   
        //}
        //else if (input == "north")
        //{
        //    x += 1;
        //    Map.PlayerLocation(x, y);
        //}
        //else if(input ==  "west")
        //{
        //    y -= 1;
        //    Map.PlayerLocation(x, y);
        //}
        //else if (input == "east")
        //{
        //    y += 1;
        //    Map.PlayerLocation(x, y);
        //}
    }
}
