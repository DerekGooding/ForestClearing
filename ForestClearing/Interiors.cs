namespace ForestClearing;

internal static class Interiors
{
    private static List<string> inventory = MainMethod.InitInventory();

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
                MainMethod.DisplayInventory(inventory);
            }
            else if (response.ToLower() == "help")
            {
                MainMethod.Help();
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
        Console.WriteLine("*******************************************************************");
        Console.WriteLine("You enter the hut and notice first how spacious it is on the inside.");
        Console.WriteLine("there are decorative columns and statues all over the place. Standing");
        Console.WriteLine("near a brazier is a man dressed in full imperial armor. He is preoccupied");
        Console.WriteLine("with feeding the brazier and didn't notice you enter.");
        Console.WriteLine("*******************************************************************");
        Console.WriteLine();

        while (true)
        {
            Console.Write("Command: ");
            string? response = Console.ReadLine();
            if (response.ToLower() == "inventory")
            {
                MainMethod.DisplayInventory(inventory);
            }
            else if (response.ToLower() == "help")
            {
                MainMethod.Help();
            }
            else if (response.ToLower() == "exit" || response.ToLower() == "exit hut")
            {
                Map.CliffFace();
            }
            else if (response.ToLower() == "talk" || response.ToLower() == "talk to hintus" || response.ToLower() == "talk hintus")
            {
                Dialogue.Hintus();
            }
            else
            {
                Console.WriteLine("I do not understand that command.");
            }
        }
    }

    internal static void Inn()
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
                MainMethod.DisplayInventory(inventory);
            }
            else if (response.ToLower() == "help")
            {
                MainMethod.Help();
            }
            else if (response.ToLower() == "exit" || response.ToLower() == "exit inn")
            {
                Map.WestTown();
            }
            else
            {
                Console.WriteLine("I do not understand that command.");
            }
        }
    }

    public static void SwampMaze(int swampCount = 0, int fatigue = 0)
    {
        ClearBeep();
        Console.WriteLine("*******************************************************************");
        Console.WriteLine("You push off on the canoe and head further east into the Swamp. Little");
        Console.WriteLine("light gets through these swamps, and a fatigue comes over you the deeper");
        Console.WriteLine("you get. The silence in the swamp is crushing, and after awhile you realize");
        Console.WriteLine("you might be lost.");
        Console.WriteLine("*******************************************************************");
        Console.WriteLine();

        while (true)
        {
            bool swampFinished = false;
            Console.Write("Command: ");
            string? response = Console.ReadLine();
            if (response.ToLower() == "inventory")
            {
                MainMethod.DisplayInventory(inventory);
            }
            else if (response.ToLower() == "help")
            {
                MainMethod.Help();
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
                MainMethod.GameOver();
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