using ForestClearing.Model;

namespace ForestClearing;

internal static class MainMethod
{
    public static void Intro()
    {
        Console.WriteLine("You wake up from a deep sleep to find yourself in a forest clearing.");
        Console.WriteLine("The trees dance lazily in the wind in all directions as you get to  ");
        Console.WriteLine("your feet. You feel a deep fatigue, like you have been hibernating. ");
        Console.WriteLine();
        Console.WriteLine("A small glowing orb the size of an egg crosses over your shoulder and");
        Console.WriteLine("hovers in-front of you at eye level, slightly pulsing. You begin to");
        Console.WriteLine("hear a voice in your head speak: ");
        Console.WriteLine();
        Console.WriteLine("You must help me traveler. I do not have much time. First I must ask");
        Console.WriteLine("you a few quick questions.");
        Console.WriteLine("If you would like some help, type help at any time...");
    }

    public static void Help()
    {
        Console.WriteLine();
        Console.WriteLine("Movement and action in this game are determined by simple commands");
        Console.WriteLine("that you enter into the console. Below is a list of commands that");
        Console.WriteLine("you can enter at anytime the console prompts you to make one.");
        Console.WriteLine("******************************************************************");

        Console.WriteLine("HELP - returns you to the help menu.");
        Console.WriteLine("INSPECT - Inspect the world around you. Use it on an item or ");
        Console.WriteLine("something specific in the environment by typing the things name after.");
        Console.WriteLine("INVENTORY - takes you to the inventory menu.");
        Console.WriteLine("TAKE - pick up an item in the environment and put it in your bag.");
        Console.WriteLine("ENTER - Enter a building or other space");
        Console.WriteLine("NORTH, SOUTH, EAST, or WEST - Moves you in the direction of choice");
        Console.WriteLine("to different destinations. You can use N, S, E, W to save time.");
        Console.WriteLine("USE (item) - uses an item of choice from your inventory or environment");
        Console.WriteLine("on the word around you but be careful and think. Items can be wasted that");
        Console.WriteLine("you might need later on!");
        Console.WriteLine("There are other commands in the game! Try ones out that might seem obvious.");
        Console.WriteLine("if you want to leave a room maybe its just as simple as saying leave or...");
    }

    public static string PlayerName()
    {
        List<MenuOption> options =
        [
            new("help", Help),
        ];
        string name = string.Empty;
        while (string.IsNullOrEmpty(name))
        {
            Write("What is your name: ");
            string? result = ReadLine();
            MenuOption? pick = options.Find(x => x.Key.Equals(result, StringComparison.OrdinalIgnoreCase));
            if(pick != null)
            {
                pick.Invoke();
            }
            else if (string.IsNullOrEmpty(result))
            {
                WriteLine("I do not understand that.");
            }
            else
            {
                name = result;
            }
        }
        return name;
    }

    public static List<string> InitInventory() => ["Pickle", "dirty penny"];

    public static void DisplayInventory(List<string> inventory) => inventory.ForEach(x => WriteLine($"- {x}"));

    public static void GameOver()
    {
        Console.Beep(220, 200);
        Console.Beep(247, 200);
        Console.Beep(262, 200);
        Console.Beep(330, 200);
        Console.Beep(262, 200);
        Console.Beep(220, 200);
        Console.Beep(247, 200);
        Console.Beep(262, 200);
        Console.Beep(330, 200);
        Console.Beep(247, 200);
        Console.Beep(220, 200);
        Console.Beep(247, 200);
        Console.Beep(262, 200);
        Console.Beep(330, 200);
        Console.Beep(262, 200);
        Console.Beep(220, 200);
        Console.Beep(247, 200);
        Console.Beep(262, 200);
        Console.Beep(330, 200);
        Console.Beep(247, 200);
        Console.Beep(220, 400);
        Console.WriteLine(" __   __  _______  __   __    ______   ___   _______  ______   __  \r\n|  | |  ||       ||  | |  |  |      | |   | |       ||      | |  | \r\n|  |_|  ||   _   ||  | |  |  |  _    ||   | |    ___||  _    ||  | \r\n|       ||  | |  ||  |_|  |  | | |   ||   | |   |___ | | |   ||  | \r\n|_     _||  |_|  ||       |  | |_|   ||   | |    ___|| |_|   ||__| \r\n  |   |  |       ||       |  |       ||   | |   |___ |       | __  \r\n  |___|  |_______||_______|  |______| |___| |_______||______| |__| ");
        Environment.Exit(0);
    }
}