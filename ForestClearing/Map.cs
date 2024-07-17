using ForestClearing.Model;

namespace ForestClearing;

internal static class Map
{
    private static readonly List<string> inventory = MainMethod.InitInventory();
    private static string previousLocation = "";

    private static void Template()
    {
        ClearBeep();
        if (previousLocation == "")
        {
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine();
        }

        previousLocation = "";

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
            }
            else if (response.ToLower() == "south")
            {
            }
            else if (response.ToLower() == "north")
            {
            }
            else if (response.ToLower() == "west")
            {
            }
            else if (response.ToLower() == "east")
            {
            }
            else
            {
                Console.Beep(200, 100);
                Console.WriteLine("I do not understand that command.");
            }
        }
    }

    public static void Clearing()
    {
        ClearBeep();
        WriteLine("*******************************************************************");
        WriteLine("You take a quick look around the clearing. There isn't much going ");
        WriteLine("on, a small creek runs east from west. The sky is cloudless. To the");
        WriteLine("North you see a path through the trees. You look West and see that ");
        WriteLine("the trees sit near a cliff face, with a small trail leading to the ");
        WriteLine("cliff. The creek heading east seems to follow a very small break in");
        WriteLine("the trees, but it looks like a tight fit. As you turn around to see");
        WriteLine("south of you, a large crash is heard. There is a large cloud of dust");
        WriteLine("coming from somewhere deep in the woods. You can see an overgrown but");
        WriteLine("but accessible trail...");
        WriteLine();
        WriteLine("*******************************************************************");

        previousLocation = "Clearing";

        List<MenuOption> options =
        [
            new("inventory", () => MainMethod.DisplayInventory(inventory)),
            new("help", MainMethod.Help),
            new("south", SouthWoods),
            new("north", NorthWoods),
            new("west", CliffFace),
            new("east", EndlessSwamp),
        ];

        CallMenu(options);
    }

    public static void EndlessSwamp()
    {
        ClearBeep();
        WriteLine("*******************************************************************");
        WriteLine("As you follow the small creek it quickly connects to a larger stream.");
        WriteLine("At the end of the stream is a vast swamp. Deep into the swamp is so");
        WriteLine("overgrown with hanging trees and mangroves that light has a hard time");
        WriteLine("penetrating it. Standing at the bank of the swamp you look around and");
        WriteLine("see there is no where else to go but further east into the actual swamp");
        WriteLine("or back west the way you came.");
        WriteLine("*******************************************************************");

        previousLocation = "EndlessSwamp";

        List<MenuOption> options =
        [
            new("inventory", () => MainMethod.DisplayInventory(inventory)),
            new("help", MainMethod.Help),
            new("south", WrongDirectionBeep),
            new("north", WrongDirectionBeep),
            new("west", Clearing),
            new("east", () => Interiors.SwampMaze()),
            new("use canoe", () => Interiors.SwampMaze()),
        ];

        CallMenu(options);
    }

    public static void CliffFace()
    {
        if (previousLocation == "Clearing")
        {
            ClearBeep();
            WriteLine("*******************************************************************");
            WriteLine("You follow the trail towards the cliff. The elevation is surprisingly");
            WriteLine("smooth as you stroll towards an open outcropping. At the top of the");
            WriteLine("outcropping you see a small hut with a sign in front of it. There is a");
            WriteLine("path going North that winds down into more woods. You can see the forest");
            WriteLine("clearing from the outcropping and further east a swamp that goes on for");
            WriteLine("what seems like forever. You can see a green light faintly in the swamp.");
            WriteLine("*******************************************************************");
        }
        else if (previousLocation == "WestWoods")
        {
            ClearBeep();
            WriteLine("*******************************************************************");
            WriteLine("You come around the cliff face from the west woods, and the terrain");
            WriteLine("gradually opens up into an outcropping. At the top, you see a small");
            WriteLine("hut with a sign in front of it. There is a path going North that winds");
            WriteLine("down into more woods. You can see the forest clearing from the outcropping");
            WriteLine("and further east a swamp that goes on for what seems like forever.");
            WriteLine("You can see a green light faintly in the swamp.");
            WriteLine("*******************************************************************");
        }

        previousLocation = "CliffFace";

        List<MenuOption> options =
        [
            new("inventory", () => MainMethod.DisplayInventory(inventory)),
            new("help", MainMethod.Help),
            new("enter hut", Interiors.HintusHut),
            new("south", WrongDirectionBeep),
            new("north", WestWoods),
            new("west", WrongDirectionBeep),
            new("east", Clearing),
            new("inspect sign", () => WriteLine("You see a sign that says \"Home of Hintus Maximus. Adventurer. Fighter. Lover.\"")),
            new("inspect", () =>
            {
                WriteLine("You see a small hut with a sign in front of it. There is a");
                WriteLine("path going North that winds down into more woods. You can see the forest");
                WriteLine("clearing from the outcropping and further east a swamp that goes on for");
                WriteLine("what seems like forever. You can see a green light faintly in the swamp.");
                WriteLine("*******************************************************************");
            }),
        ];

        CallMenu(options);
    }

    public static void NorthWoods()
    {
        ClearBeep();
        if (previousLocation == "Clearing")
        {
            WriteLine("*******************************************************************");
            WriteLine("You follow the path from the clearing as it takes you deeper into");
            WriteLine("the woods. You notice that this area is much calmer and peaceful");
            WriteLine("than the place you came from. You can hear birds chattering in the");
            WriteLine("trees. The trail opens into a small glade, with a giant sprawling");
            WriteLine("willow next to a small pool. The water at the pool is cool and clear.");
            WriteLine("*******************************************************************");
            WriteLine();
        }
        else if (previousLocation == "WestWoods")
        {
            WriteLine("*******************************************************************");
            WriteLine("You follow the path from the woods east into the forest the light from");
            WriteLine("above trees dances on the forest floor. The trail opens into a small");
            WriteLine("glade, with a giant sprawling willow next to a small pool. The water");
            WriteLine("at the pool is cool and clear.");
            WriteLine("*******************************************************************");
            WriteLine();
        }
        else
        {
            WriteLine("*******************************************************************");
            WriteLine("You follow the path from the plains south back into the forest. The");
            WriteLine("trail opens into a small glade, with a giant sprawling willow next to");
            WriteLine("a small pool. The water at the pool is cool and clear.");
            WriteLine("*******************************************************************");
            WriteLine();
        }

        previousLocation = "NorthWoods";

        List<MenuOption> options =
        [
            new("inventory", () => MainMethod.DisplayInventory(inventory)),
            new("help", MainMethod.Help),
            new("south", Clearing),
            new("north", Field),
            new("west", WestWoods),
            new("east", WrongDirectionBeep),
            new("drink water", () =>
            {
                Clear();
                WriteLine("*******************************************************************");
                WriteLine("You drop down next to the pool and stick your face in it to take a");
                WriteLine("large drink. The water is cool and refreshing. A small bird above you");
                WriteLine("in the willow is jumping around frantically. Its sing-song chirping");
                WriteLine("sounds suspiciously like English at times.");
                WriteLine();
                WriteLine("Suddenly you feel a deep burning within your stomach. And a rising");
                WriteLine("feeling of doom strikes you. Your body feels like its burning. A sudden,");
                WriteLine("delirious fever takes over you and you collapse. You start to shake and");
                WriteLine("writhe on the ground before fading to black. You feel a burning liquid");
                WriteLine("spill out of your body as you perish.");
                WriteLine("*******************************************************************");
                WriteLine();
                MainMethod.GameOver();
            }),
            new("inspect", () =>
            {
                Beep(800, 40);
                WriteLine("*******************************************************************");
                WriteLine("You see a large willow with hanging branches. It sits next to a small");
                WriteLine("pool. To the north the path winds around the tree into more woods.");
                WriteLine("To the west is another forest path. There is nothing to the east.");
                WriteLine("*******************************************************************");
            }),
            new("inspect tree", () =>
            {
                Beep(800, 40);
                WriteLine("*******************************************************************");
                WriteLine("You give the tree a closer look. Moss grows along the base and trunk");
                WriteLine("of it which is as wide as three or four trees. It looks old and ancient");
                WriteLine("The branches dip so low they kiss the pool occasionally, sending soft");
                WriteLine("ripples on its surface. A small yellow bird lands on a branch and");
                WriteLine("looks at you curiously. It sings a quiet sound that strangely sounds");
                WriteLine("like words.");
                WriteLine("*******************************************************************");
            }),
            new("inspect pool", () =>
            {
                Beep(1100, 40);
                Beep(1000, 100);
                Beep(1100, 40);
                Beep(900, 100);
                Beep(1200, 40);
                WriteLine("*******************************************************************");
                WriteLine("You walk closer to the base of the tree to look into the pool. Around ");
                WriteLine("the pool small flowers and mushrooms sit. They look pristine and untouched.");
                WriteLine("You gaze into the pool, it is so clear that you can see straight to the");
                WriteLine("bottom. There is a small gold coin sitting among the pebbles and rocks.");
                WriteLine("*******************************************************************");
            }),
            new("talk bird", Dialogue.SmallBird),
            new("talk to bird", Dialogue.SmallBird),
        ];

        CallMenu(options);
    }

    public static void Field()
    {
        ClearBeep();
        if (previousLocation == "NorthWoods")
        {
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("You make your way around the tree and continue North. As you walk");
            Console.WriteLine("along the forest path the trees start to thin and you can feel the sun");
            Console.WriteLine("on your face. The trees finally break completely and you walk into a");
            Console.WriteLine("large plain. The plain is scattered with small farms and solitary trees.");
            Console.WriteLine("The path connects to a cobblestone road. To the North in the distance");
            Console.WriteLine("you see a small town, surrounded by more farms. To the east you see a");
            Console.WriteLine("graveyard and a strange man guarding the road. The road winds west");
            Console.WriteLine("down to the bank of a large river that flows north through the town.");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine();
        }
        else if (previousLocation == "River")
        {
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("You leave the river and head east. The road widens as you come closer");
            Console.WriteLine("to a cross roads sitting in a large plain. The plain is scattered with");
            Console.WriteLine("with small farms and solitary trees.The path connects to a cobblestone");
            Console.WriteLine("road. To the North in the distance you see a small town, surrounded by");
            Console.WriteLine("more farms. To the east you see a graveyard and a strange man guarding");
            Console.WriteLine("the road. The road winds west down to the bank of a large river that");
            Console.WriteLine("flows north through the town.");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine();
        }
        previousLocation = "Field";

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
            else if (response.ToLower() == "south")
            {
                Map.NorthWoods();
            }
            else if (response.ToLower() == "north")
            {
                Map.Town();
            }
            else if (response.ToLower() == "west")
            {
                Map.River();
            }
            else if (response.ToLower() == "east")
            {
                //Graveyard event
            }
            else
            {
                Console.Beep(200, 100);
                Console.WriteLine("I do not understand that command.");
            }
        }
    }

    public static void Town()
    {
        ClearBeep();
        if (previousLocation == "Field")
        {
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("You take the road North. The road is attached to small hamlets and");
            Console.WriteLine("cottages that sit on small farms. Most homes have small or gnarled");
            Console.WriteLine("trees attached to them. You pass fields of barley and other grains.");
            Console.WriteLine();
            Console.WriteLine("You reach the town and notice there is no gate or major defenses.");
            Console.WriteLine("Townspeople walk lazily about, there doesn't seem to be much urgency");
            Console.WriteLine("in anyone. The road goes through the town and you arrive at a courtyard");
            Console.WriteLine("The north side of the courtyard is lined with tall narrow buildings and");
            Console.WriteLine("and a small street that connects to the main road that goes east or");
            Console.WriteLine("west further into different parts of the town.");
            Console.WriteLine("******************************************************************");
            Console.WriteLine();
        }
        else if (previousLocation == "WestTown")
        {
            Console.WriteLine("******************************************************************");
            Console.WriteLine("You make your way to the center of town.");
            Console.WriteLine();
            Console.WriteLine("Townspeople walk lazily about, there doesn't seem to be much urgency");
            Console.WriteLine("in anyone. The road goes through the town and you arrive at a courtyard");
            Console.WriteLine("The north side of the courtyard is lined with tall narrow buildings and");
            Console.WriteLine("and a small street that connects to the main road that goes east or");
            Console.WriteLine("west further into different parts of the town.");
            Console.WriteLine("******************************************************************");
            Console.WriteLine();
        }
        else if (previousLocation == "EastTown")
        {
            Console.WriteLine("You make your way west to the center of town.");
            Console.WriteLine();
            Console.WriteLine("Townspeople walk lazily about, there doesn't seem to be much urgency");
            Console.WriteLine("in anyone. The road goes through the town and you arrive at a courtyard");
            Console.WriteLine("The north side of the courtyard is lined with tall narrow buildings and");
            Console.WriteLine("and a small street that connects to the main road that goes east or");
            Console.WriteLine("west further into different parts of the town.");
            Console.WriteLine("******************************************************************");
            Console.WriteLine();
        }

        previousLocation = "Town";

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
            else if (response.ToLower() == "south")
            {
                Map.Field();
            }
            else if (response.ToLower() == "north")
            {
            }
            else if (response.ToLower() == "west")
            {
                Map.WestTown();
            }
            else if (response.ToLower() == "east")
            {
                Map.EastTown();
            }
            else
            {
                Console.Beep(200, 100);
                Console.WriteLine("I do not understand that command.");
            }
        }
    }

    public static void EastTown()
    {
        ClearBeep();
        if (previousLocation == "Town")
        {
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("You start to walk East. The road bends south slightly and the town");
            Console.WriteLine("begins to thin out into a smaller field. The homes on this side of");
            Console.WriteLine("town are much larger, and instead of farms these homes are covered in");
            Console.WriteLine("beautiful gardens and stone sculptures. Some of the homes are made of");
            Console.WriteLine("polished stone. There is a small road south that leads to a massive");
            Console.WriteLine("church.");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine();
        }
        else if (previousLocation == "Church")
        {
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("You leave the church grounds and move North. The homes on this side of");
            Console.WriteLine("town are much larger, and instead of farms these homes are covered in");
            Console.WriteLine("beautiful gardens and stone sculptures. Some of the homes are made of");
            Console.WriteLine("polished stone. There is a small road south that leads to a massive");
            Console.WriteLine("church.");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine();
        }

        previousLocation = "EastTown";

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
            else if (response.ToLower() == "south")
            {
                Map.Church();
            }
            else if (response.ToLower() == "north")
            {
                Console.WriteLine("Behind the houses to the North are steep hills. They look impassible.");
            }
            else if (response.ToLower() == "west")
            {
                Map.Town();
            }
            else if (response.ToLower() == "east")
            {
                Console.WriteLine("There is nothing east but plains.");
            }
            else
            {
                Console.Beep(200, 100);
                Console.WriteLine("I do not understand that command.");
            }
        }
    }

    public static void Church()
    {
        ClearBeep();
        if (previousLocation == "EastTown")
        {
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("You follow the path south and reach the front of a large church. The");
            Console.WriteLine("church appears to be abandoned. To the south is a large graveyard,");
            Console.WriteLine("which is blocked and bordered by a large iron fence.");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine();
        }

        previousLocation = "Church";

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
            else if (response.ToLower() == "south")
            {
                Console.WriteLine("Your path to the graveyard is blocked by a tall iron fence that");
                Console.WriteLine("wraps around the entire graveyard.");
            }
            else if (response.ToLower() == "north")
            {
                Map.EastTown();
            }
            else if (response.ToLower() == "west")
            {
                Console.WriteLine("There is nothing that way for you.");
            }
            else if (response.ToLower() == "east")
            {
                Console.WriteLine("There is nothing that way for you.");
            }
            else if (response.ToLower() == "inspect church")
            {
                Console.WriteLine("*******************************************************************");
                Console.WriteLine("The church appears to be in disrepair. A large tower sits to");
                Console.WriteLine("the west side of the church. The massive wood door in front");
                Console.WriteLine("seems to be the only part of the church not left to the elements");
                Console.WriteLine("Intricate carvings of nature cover the door, which is bordered");
                Console.WriteLine("with gold inlay.");
                Console.WriteLine("*******************************************************************");
                Console.WriteLine();
            }
            else
            {
                Console.Beep(200, 100);
                Console.WriteLine("I do not understand that command.");
            }
        }
    }

    public static void WestTown()
    {
        ClearBeep();
        if (previousLocation == "Town")
        {
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("You make your way East. This part of town is quieter and sits next to");
            Console.WriteLine("a river. At the end of the street is an Inn. You can see people drinking");
            Console.WriteLine("under an awning in front of the Inn, next to it on the river bank you see");
            Console.WriteLine("a small dock with a canoe.");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine();
        }
        else if (previousLocation == "River")
        {
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("You make your way North. This part of the town is quieter and sits");
            Console.WriteLine(" next to the river. At the end of the street is an Inn. You can see");
            Console.WriteLine("people drinking under an awning in front of the Inn, next to it on the");
            Console.WriteLine("river bank you see a small dock with a canoe.");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine();
        }

        previousLocation = "WestTown";

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
            else if (response.ToLower() == "south")
            {
                Map.River();
            }
            else if (response.ToLower() == "north")
            {
                Console.WriteLine("There are some smaller homes and buildings to the north");
                Console.WriteLine("but there doesn't seem to be much going on there");
            }
            else if (response.ToLower() == "west")
            {
                Console.WriteLine("West is the Inn, which appears to be open.");
            }
            else if (response.ToLower() == "east")
            {
                Map.Town();
            }
            else if (response.ToLower() == "enter inn")
            {
                Interiors.Inn();
            }
            else
            {
                Console.Beep(200, 100);
                Console.WriteLine("I do not understand that command.");
            }
        }
    }

    public static void River()
    {
        ClearBeep();
        Console.WriteLine("*******************************************************************");
        Console.WriteLine("You take the road west towards the river. As you get closer the road");
        Console.WriteLine("starts to narrow. This portion of the road is much older and the stones");
        Console.WriteLine("are loose in some places. The road winds North-West towards the bank and");
        Console.WriteLine("just south of the town. There is a small Inn connected to the River by");
        Console.WriteLine("a water wheel, there seems to be a dock on the other side of the Inn.");
        Console.WriteLine("Small cranes stand stoically on the rocky bank of the River, and you can");
        Console.WriteLine("hear a lively crowd within the Inn up ahead.");
        Console.WriteLine("*******************************************************************");
        Console.WriteLine();

        previousLocation = "River";

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
            else if (response.ToLower() == "south")
            {
                Console.WriteLine("Forest blocks your path to the South.");
            }
            else if (response.ToLower() == "north")
            {
                Map.WestTown();
            }
            else if (response.ToLower() == "west")
            {
                Console.Beep(200, 100);
                Console.WriteLine("To the West is a river. Walking isn't recommended.");
            }
            else if (response.ToLower() == "east")
            {
                Map.Field();
            }
            else
            {
                Console.Beep(200, 100);
                Console.WriteLine("I do not understand that command.");
            }
        }
    }

    public static void WestWoods()
    {
        if (previousLocation == "CliffFace")
        {
            ClearBeep();
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("You follow the path north that goes down into the woods. The path is");
            Console.WriteLine("steep and you walk slow and steady until you reach an opening into the");
            Console.WriteLine("woods. You are sweating slightly as you walk along a creek path. This");
            Console.WriteLine("area of the woods is calm. You reach a small opening into the woods.");
            Console.WriteLine("There is a sign next to a small bench carved out of a fallen tree. The");
            Console.WriteLine("creek flows north where the trail breaks into a dense forest.");
            Console.WriteLine("*******************************************************************");
        }
        else if (previousLocation == "NorthWoods")
        {
            ClearBeep();
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("You take the path west from the small glade. The path seems well-");
            Console.WriteLine("maintained and you can hear a creek bubbling up ahead. You enter a");
            Console.WriteLine("quiet area of the woods. You can see a creek following a path. There");
            Console.WriteLine("is a sign next to a small bench carved out of a fallen tree. The");
            Console.WriteLine("creek flows north where the trail breaks into a dense forest.");
            Console.WriteLine("*******************************************************************");
        }
        previousLocation = "WestWoods";

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
            else if (response.ToLower() == "south")
            {
                Map.CliffFace();
            }
            else if (response.ToLower() == "north" || (response.ToLower() == "west"))
            {
                Console.Beep(200, 100);
                Console.WriteLine("You cannot go that way.");
            }
            else if (response.ToLower() == "east")
            {
                Map.NorthWoods();
            }
            else
            {
                Console.Beep(200, 100);
                Console.WriteLine("I do not understand that command.");
            }
        }
    }

    public static void SouthWoods()
    {
        ClearBeep();
        Console.WriteLine("******************************************************************");
        Console.WriteLine("You make your way south through the overgrown trail. The deeper you");
        Console.WriteLine("go the tighter the trail gets, and branches start to snag at you.");
        Console.WriteLine("As you struggle along you catch sight of a smaller open patch. There");
        Console.WriteLine("is something shuffling around ahead. There is nothing to the east");
        Console.WriteLine("or west of you. Your choices are to continue south or move north");
        Console.WriteLine("back to the clearing.");
        Console.WriteLine();
        Console.WriteLine("******************************************************************");

        previousLocation = "SouthWoods";

        while (true)
        {
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
                Map.SouthSouthWoods();
            }
            else if (response.ToLower() == "north")
            {
                Map.Clearing();
            }
            else if (response.ToLower() == "west")
            {
                Console.Beep(200, 100);
                Console.WriteLine("You cannot go that way.");
            }
            else if (response.ToLower() == "east")
            {
                Console.Beep(200, 100);
                Console.WriteLine("You cannot go that way.");
            }
            else
            {
                Console.WriteLine("I do not understand that command.");
            }
        }
    }

    public static void SouthSouthWoods()
    {
        ClearBeep();
        Console.WriteLine("*******************************************************************");
        Console.WriteLine("As you continue along the path and into the open patch you catch a");
        Console.WriteLine("proper look at the thing shuffling around, and what you realize was");
        Console.WriteLine("The source of all that commotion. Whats in front of you is a large,");
        Console.WriteLine("bear-like creature. With 8 inch claws and razor sharp fangs. At its");
        Console.WriteLine("feet is a small unidentifiable, but very much dead animal. There is");
        Console.WriteLine("no path out but back from North. The creature turns to you, its eyes");
        Console.WriteLine("black and skin both furry and scaly at the same time. It roars and ");
        Console.WriteLine("charges you.");
        Console.WriteLine();
        Console.WriteLine("*******************************************************************");
        Console.WriteLine();

        previousLocation = "SouthSouthWoods";

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
            else if (response.ToLower() == "south")
            {
                Console.Beep(200, 100);
                Console.WriteLine("You cannot go that way.");
            }
            else if (response.ToLower() == "north")
            {
                Console.Clear();
                Console.WriteLine("*******************************************************************");
                Console.WriteLine("You turn quickly and run. The thing chasing you shakes the ground as");
                Console.WriteLine("it follows. Branches on the overgrown path snag at your clothes and");
                Console.WriteLine("slow you down. You can see the light from the forest clearing ahead.");
                Console.WriteLine("The foul creature closes the gap and as it gets closer you can smell");
                Console.WriteLine("its rotten, putrid breath on your neck. It swipes at your leg and you");
                Console.WriteLine("fall on your hands and knees. The creature uses its long claws to rake");
                Console.WriteLine("your lower abdomen. Your intestines spill out of your body.");
                Console.WriteLine();
                Console.WriteLine("As you frantically grab your innards and try to put them back where");
                Console.WriteLine("they belong, the beast looks at you curiously and sniffs your entrails.");
                Console.WriteLine("As soon as it gets a good whiff, its eyes dilate and a thick yellow");
                Console.WriteLine("liquid drips from its maw. It dives in hungrily and starts to eat");
                Console.WriteLine("your innards like spaghetti. The light from the clearing and the light");
                Console.WriteLine("in your eyes fade rapidly. MAMA MIA! is the last thing you think before");
                Console.WriteLine("everything goes black.");
                Console.WriteLine("*******************************************************************");
                Console.WriteLine();
                MainMethod.GameOver();
            }
            else if (response.ToLower() == "use pickle")
            {
                Console.WriteLine("You toss a pickle at the beast and it looks at the pickle and then you curiously.");
            }
            else if (response.ToLower() == "attack" || response.ToLower() == "fight")
            {
                Console.Clear();
                Console.WriteLine("*******************************************************************");
                Console.WriteLine("You charge the beast valiantly. You don't have a weapon so you grab");
                Console.WriteLine("ahold of the beasts fur in an attempt to throw it to the ground. All");
                Console.WriteLine("six hundred pounds of the creature simply sits on you and you feel the");
                Console.WriteLine("crushing pressure suck the air out of your lungs. The beast swipes once");
                Console.WriteLine("at your face raking it open. His next swipe is at your throat and you");
                Console.WriteLine("bleed out almost immediately.");
                Console.WriteLine();
                Console.WriteLine("What it the world made you think you could pull that off?");
                Console.WriteLine("*******************************************************************");
                Console.WriteLine();
                MainMethod.GameOver();
            }
            else if (response.ToLower() == "west")
            {
                Console.Beep(200, 100);
                Console.WriteLine("You cannot go that way.");
            }
            else if (response.ToLower() == "east")
            {
                Console.Beep(200, 100);
                Console.WriteLine("You cannot go that way.");
            }
            else
            {
                Console.Beep(200, 100);
                Console.WriteLine("I do not understand that command.");
            }
        }
    }

    internal static void SwampIsland()
    {
        ClearBeep();
        if (previousLocation == "EndlessSwamp")
        {
            Console.Beep(1100, 40);
            Console.Beep(1000, 100);
            Console.Beep(1100, 40);
            Console.Beep(900, 100);
            Console.Beep(1200, 40);
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("You made it!!!");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine();
        }

        previousLocation = "";

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
            }
            else if (response.ToLower() == "south")
            {
            }
            else if (response.ToLower() == "north")
            {
            }
            else if (response.ToLower() == "west")
            {
            }
            else if (response.ToLower() == "east")
            {
            }
            else
            {
                Console.Beep(200, 100);
                Console.WriteLine("I do not understand that command.");
            }
        }
    }
}