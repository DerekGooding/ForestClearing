using ForestClearing.Model;

namespace ForestClearing;

internal static class Main
{
    public static void Intro()
    {
        WriteLine("You wake up from a deep sleep to find yourself in a forest clearing.");
        WriteLine("The trees dance lazily in the wind in all directions as you get to  ");
        WriteLine("your feet. You feel a deep fatigue, like you have been hibernating. ");
        WriteLine();
        WriteLine("A small glowing orb the size of an egg crosses over your shoulder and");
        WriteLine("hovers in-front of you at eye level, slightly pulsing. You begin to");
        WriteLine("hear a voice in your head speak: ");
        WriteLine();
        WriteLine("You must help me traveler. I do not have much time. First I must ask");
        WriteLine("you a few quick questions.");
        WriteLine("If you would like some help, type help at any time...");
    }

    public static void Help()
    {
        WriteLine();
        WriteLine("Movement and action in this game are determined by simple commands");
        WriteLine("that you enter into the console. Below is a list of commands that");
        WriteLine("you can enter at anytime the console prompts you to make one.");
        WriteLine("******************************************************************");

        WriteLine("HELP - returns you to the help menu.");
        WriteLine("INSPECT - Inspect the world around you. Use it on an item or ");
        WriteLine("something specific in the environment by typing the things name after.");
        WriteLine("INVENTORY - takes you to the inventory menu.");
        WriteLine("TAKE - pick up an item in the environment and put it in your bag.");
        WriteLine("ENTER - Enter a building or other space");
        WriteLine("NORTH, SOUTH, EAST, or WEST - Moves you in the direction of choice");
        WriteLine("to different destinations. You can use N, S, E, W to save time.");
        WriteLine("USE (item) - uses an item of choice from your inventory or environment");
        WriteLine("on the word around you but be careful and think. Items can be wasted that");
        WriteLine("you might need later on!");
        WriteLine("There are other commands in the game! Try ones out that might seem obvious.");
        WriteLine("if you want to leave a room maybe its just as simple as saying leave or...");
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
            string? response = ReadLine();
            MenuOption? pick = options.Find(x => x.Key.Equals(response, StringComparison.OrdinalIgnoreCase));
            if(pick != null)
            {
                pick.Invoke();
            }
            else if (string.IsNullOrEmpty(response))
            {
                WriteLine("I do not understand that.");
            }
            else
            {
                name = response;
            }
        }
        return name;
    }

    public static List<string> Inventory => ["Pickle", "dirty penny"];

    public static void DisplayInventory() => Inventory.ForEach(x => WriteLine($"- {x}"));

    public static void GameOver()
    {
        Beep(220, 200);
        Beep(247, 200);
        Beep(262, 200);
        Beep(330, 200);
        Beep(262, 200);
        Beep(220, 200);
        Beep(247, 200);
        Beep(262, 200);
        Beep(330, 200);
        Beep(247, 200);
        Beep(220, 200);
        Beep(247, 200);
        Beep(262, 200);
        Beep(330, 200);
        Beep(262, 200);
        Beep(220, 200);
        Beep(247, 200);
        Beep(262, 200);
        Beep(330, 200);
        Beep(247, 200);
        Beep(220, 400);
        WriteLine(" __   __  _______  __   __    ______   ___   _______  ______   __  \r\n|  | |  ||       ||  | |  |  |      | |   | |       ||      | |  | \r\n|  |_|  ||   _   ||  | |  |  |  _    ||   | |    ___||  _    ||  | \r\n|       ||  | |  ||  |_|  |  | | |   ||   | |   |___ | | |   ||  | \r\n|_     _||  |_|  ||       |  | |_|   ||   | |    ___|| |_|   ||__| \r\n  |   |  |       ||       |  |       ||   | |   |___ |       | __  \r\n  |___|  |_______||_______|  |______| |___| |_______||______| |__| ");
        Environment.Exit(0);
    }
}