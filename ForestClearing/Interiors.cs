using ForestClearing.Model;

namespace ForestClearing;

internal static class Interiors
{
    internal static void Template()
    {
        ClearBeep();
        Console.WriteLine("*******************************************************************");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("*******************************************************************");
        Console.WriteLine();

        while (true)
        {
            Console.Write("Command: ");
            string? response = Console.ReadLine();
            if (response.ToLower() == "inventory")
            {
                Main.DisplayInventory();
            }
            else if (response.ToLower() == "help")
            {
                Main.Help();
            }
            else if (response.ToLower() == "exit")
            {
            }
            else
            {
                Console.WriteLine("I do not understand that command.");
            }
        }
    }

    internal static void HintusHut()
    {
        ClearBeep();
        WriteLine("*******************************************************************");
        WriteLine("You enter the hut and notice first how spacious it is on the inside.");
        WriteLine("there are decorative columns and statues all over the place. Standing");
        WriteLine("near a brazier is a man dressed in full imperial armor. He is preoccupied");
        WriteLine("with feeding the brazier and didn't notice you enter.");
        WriteLine("*******************************************************************");
        WriteLine();

        List<MenuOption> options = [];
        options.AddRange(DefaultOptions);
        options.AddRange(SameResult(["exit", "exit hut"], Map.CliffFace));
        options.AddRange(SameResult(["talk", "talk to hintus", "talk hintus"], Dialogue.Hintus));

        CallMenu(options);
    }

    internal static void Inn()
    {
        ClearBeep();
        WriteLine("*******************************************************************");
        WriteLine("");
        WriteLine("");
        WriteLine("");
        WriteLine("");
        WriteLine("*******************************************************************");
        WriteLine();

        List<MenuOption> options = [];
        options.AddRange(DefaultOptions);
        options.AddRange(SameResult(["exit", "exit inn"], Map.WestTown));

        CallMenu(options);
    }

    public static void SwampMaze(int swampCount = 0, int fatigue = 0)
    {
        ClearBeep();
        WriteLine("*******************************************************************");
        WriteLine("You push off on the canoe and head further east into the Swamp. Little");
        WriteLine("light gets through these swamps, and a fatigue comes over you the deeper");
        WriteLine("you get. The silence in the swamp is crushing, and after awhile you realize");
        WriteLine("you might be lost.");
        WriteLine("*******************************************************************");
        WriteLine();

        while (true)
        {
            bool swampFinished = false;
            Console.Write("Command: ");
            string? response = Console.ReadLine();
            if (response.ToLower() == "inventory")
            {
                Main.DisplayInventory();
            }
            else if (response.ToLower() == "help")
            {
                Main.Help();
            }
            else if (response.ToLower() == "south")
            {
                if (swampCount == 3)
                {
                    Map.SwampIsland();
                    swampFinished = true;
                }
                else
                {
                    ClearBeep();
                    Console.WriteLine("*******************************************************************");
                    Console.WriteLine("You move South and are surrounded by swamp");
                    Console.WriteLine("*******************************************************************");
                    swampCount = SwampLogic(0);
                    fatigue = KillerFatigue(fatigue);
                }
            }
            else if (response.ToLower() == "north")
            {
                if (swampCount == 0)
                {
                    ClearBeep();
                    Console.WriteLine("*******************************************************************");
                    Console.WriteLine("You move North and are surrounded by swamp");
                    Console.WriteLine("*******************************************************************");
                    swampCount = SwampLogic(1); // Update swampCount
                    fatigue = KillerFatigue(fatigue);
                }
                else
                {
                    ClearBeep();
                    Console.WriteLine("*******************************************************************");
                    Console.WriteLine("You move North and are surrounded by swamp");
                    Console.WriteLine("*******************************************************************");
                    swampCount = SwampLogic(0); // Reset swampCount
                    fatigue = KillerFatigue(fatigue);
                }
            }
            else if (response.ToLower() == "west")
            {
                if (swampCount == 1)
                {
                    ClearBeep();
                    Console.WriteLine("*******************************************************************");
                    Console.WriteLine("You move West and are surrounded by swamp");
                    Console.WriteLine("*******************************************************************");
                    swampCount = SwampLogic(2);
                    fatigue = KillerFatigue(fatigue);
                }
                else if (swampCount == 2)
                {
                    ClearBeep();
                    Console.WriteLine("*******************************************************************");
                    Console.WriteLine("You move West and are surrounded by swamp");
                    Console.WriteLine("*******************************************************************");
                    swampCount = SwampLogic(3);
                    fatigue = KillerFatigue(fatigue);
                }
                else
                {
                    ClearBeep();
                    Console.WriteLine("*******************************************************************");
                    Console.WriteLine("You move West and are surrounded by swamp");
                    Console.WriteLine("*******************************************************************");
                    swampCount = SwampLogic(0);
                    fatigue = KillerFatigue(fatigue);
                }
            }
            else if (response.ToLower() == "east")
            {
                ClearBeep();
                Console.WriteLine("*******************************************************************");
                Console.WriteLine("You move East and are surrounded by swamp");
                Console.WriteLine("*******************************************************************");
                swampCount = SwampLogic(0);
                fatigue = KillerFatigue(fatigue);
            }
            if (fatigue >= 3) // Replace with your desired fatal threshold
            {
                Console.WriteLine();
                Console.WriteLine("You are starting to feel extremely tired.");
                Console.WriteLine();
            }
            if (fatigue >= 6)
            {
                Console.WriteLine();
                Console.WriteLine("Every use of the paddle feels like it takes up all of your energy.");
                Console.WriteLine("You have never been this tired in your life.");
                Console.WriteLine();
            }
            if (fatigue >= 9)
            {
                Console.WriteLine();
                Console.WriteLine("Your vision drops to a pinpoint. It feels hard to even breathe.");
                Console.WriteLine("You dont know how much longer you can go on.");
                Console.WriteLine();
            }
            if (fatigue >= 10)
            {
                Console.Clear();
                Console.WriteLine("*******************************************************************");
                Console.WriteLine("With one last burst of energy you try to paddle but its useless. The once");
                Console.WriteLine("quiet swamp now feels bursting with sound and life. Black tendrils grasp");
                Console.WriteLine("and pull at your arms and you have no strength to fight. You close your");
                Console.WriteLine("eyes and feel yourself get pulled into warm waters. You are being pulled");
                Console.WriteLine("further down and the urge to breathe is burning in your chest. You fight");
                Console.WriteLine("with what little strength you can muster before sucking in thick globs");
                Console.WriteLine("of warm swamp. The tendrils wrap around you tighter and you are pulled");
                Console.WriteLine("into the deep, never to surface.");
                Console.WriteLine("*******************************************************************");
                Console.WriteLine();
                Main.GameOver();
                break;
            }
            if (swampFinished)
            {
                break;
            }
        }
    }

    public static int SwampLogic(int swampAdd) => swampAdd;

    public static int KillerFatigue(int SwampFatigue) => SwampFatigue + 1;
}