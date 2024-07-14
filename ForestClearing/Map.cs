using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestClearing
{
    internal class Map
    {
        static List<string> inventory = MainMethod.InitInventory();
        private static string previousLocation = "";
        private static void Template()
        {
            Console.Beep(800, 40);
            Console.Clear();
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine();

            previousLocation = "";

            while (true)
            {
                Console.Write("Command: ");
                string response = Console.ReadLine();
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
                    Map.SouthWoods();
                }
                else if (response.ToLower() == "north")
                {
                    Map.NorthWoods();
                }
                else if (response.ToLower() == "west")
                {
                    Map.CliffFace();
                }
                else if (response.ToLower() == "east")
                {
                    Map.EndlessSwamp();
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
            Console.Beep(800, 40);
            Console.Clear();
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("You take a quick look around the clearing. There isn't much going " );
            Console.WriteLine("on, a small creek runs east from west. The sky is cloudless. To the");
            Console.WriteLine("North you see a path through the trees. You look West and see that ");
            Console.WriteLine("the trees sit near a cliff face, with a small trail leading to the ");
            Console.WriteLine("cliff. The creek heading east seems to follow a very small break in");
            Console.WriteLine("the trees, but it looks like a tight fit. As you turn around to see");                                                               
            Console.WriteLine("south of you, a large crash is heard. There is a large cloud of dust");
            Console.WriteLine("coming from somewhere deep in the woods. You can see an overgrown but"); 
            Console.WriteLine("but accessible trail...");
            Console.WriteLine();
            Console.WriteLine("*******************************************************************");

            previousLocation = "Clearing";

            while (true)
            {
                Console.Write("Command: ");
                string response = Console.ReadLine();
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
                    Map.SouthWoods();
                }
                else if (response.ToLower() == "north")
                {
                    Map.NorthWoods();
                }
                else if (response.ToLower() == "west")
                {
                    Map.CliffFace();
                }
                else if (response.ToLower() == "east")
                {
                    Map.EndlessSwamp();
                }
                else
                {
                    Console.WriteLine("I do not understand that command.");
                } 
            }
        }

        public static void EndlessSwamp()
        {
            Console.Beep(800, 40);
            Console.Clear();
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("As you follow the small creek it quickly connects to a larger stream.");
            Console.WriteLine("At the end of the stream is a vast swamp. Deep into the swamp is so");
            Console.WriteLine("overgrown with hanging trees and mangroves that light has a hard time");
            Console.WriteLine("penetrating it. Standing at the bank of the swamp you look around and");
            Console.WriteLine("see there is no where else to go but further east into the actual swamp");
            Console.WriteLine("or back west the way you came.");
            Console.WriteLine("*******************************************************************");

            previousLocation = "EndlessSwamp";

            while (true)
            {
                Console.Write("Command: ");
                string response = Console.ReadLine();
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
                    Console.Beep(200, 100);
                    Console.WriteLine("You cannot go that way.");
                }
                else if (response.ToLower() == "west")
                {
                    Map.Clearing();
                }
                else if (response.ToLower() == "east")
                {
                    Console.Beep(200, 100);
                    Console.WriteLine("The water is much too deep to walk.");
                }
                else
                {
                    Console.WriteLine("I do not understand that command.");
                }
            }
        }

        public static void CliffFace()
        {
            if (previousLocation == "Clearing")
            {
                Console.Beep(800, 40);
                Console.Clear();
                Console.WriteLine("*******************************************************************");
                Console.WriteLine("You follow the trail towards the cliff. The elevation is surprisingly");
                Console.WriteLine("smooth as you stroll towards an open outcropping. At the top of the");
                Console.WriteLine("outcropping you see a small hut with a sign in front of it. There is a");
                Console.WriteLine("path going North that winds down into more woods. You can see the forest");
                Console.WriteLine("clearing from the outcropping and further east a swamp that goes on for");
                Console.WriteLine("what seems like forever. You can see a green light faintly in the swamp.");
                Console.WriteLine("*******************************************************************");
            }
            else if (previousLocation == "WestWoods")
            {
                Console.Beep(800, 40);
                Console.Clear();
                Console.WriteLine("*******************************************************************");
                Console.WriteLine("You come around the cliff face from the west woods, and the terrain");
                Console.WriteLine("gradually opens up into an outcropping. At the top, you see a small");
                Console.WriteLine("hut with a sign in front of it. There is a path going North that winds");
                Console.WriteLine("down into more woods. You can see the forest clearing from the outcropping");
                Console.WriteLine("and further east a swamp that goes on for what seems like forever.");
                Console.WriteLine("You can see a green light faintly in the swamp.");
                Console.WriteLine("*******************************************************************");
            }


            previousLocation = "CliffFace";

            while (true)
            {
                Console.Write("Command: ");
                string response = Console.ReadLine();
                if (response.ToLower() == "inventory")
                {
                    MainMethod.DisplayInventory(inventory);
                }
                else if (response.ToLower() == "help")
                {
                    MainMethod.Help();
                }
                else if (response.ToLower() == "enter hut")
                {
                    Interiors.HintusHut();
                }
                else if (response.ToLower() == "south")
                {
                    Console.Beep(200, 100);
                    Console.WriteLine("You cannot go that way.");
                }
                else if (response.ToLower() == "north")
                {
                    Map.WestWoods();
                }
                else if (response.ToLower() == "west")
                {
                    Console.Beep(200, 100);
                    Console.WriteLine("You cannot go that way.");
                }
                else if (response.ToLower() == "east")
                {
                    Map.Clearing();
                }
                else if (response.ToLower() == "inspect sign")
                {
                    Console.WriteLine("You see a sign that says \"Home of Hintus Maximus. Adventurer. Fighter. Lover.\"");
                }
                else if (response.ToLower() == "inspect")
                {
                    
                    Console.WriteLine("You see a small hut with a sign in front of it. There is a");
                    Console.WriteLine("path going North that winds down into more woods. You can see the forest");
                    Console.WriteLine("clearing from the outcropping and further east a swamp that goes on for");
                    Console.WriteLine("what seems like forever. You can see a green light faintly in the swamp.");
                    Console.WriteLine("*******************************************************************");
                }
                else
                {
                    Console.WriteLine("I do not understand that command.");
                }
            }
        }

        public static void NorthWoods()
        {
            Console.Beep(800, 40);
            Console.Clear();
            if (previousLocation == "Clearing")
            {
                Console.WriteLine("*******************************************************************");
                Console.WriteLine("You follow the path from the clearing as it takes you deeper into");
                Console.WriteLine("the woods. You notice that this area is much calmer and peaceful");
                Console.WriteLine("than the place you came from. You can hear birds chattering in the");
                Console.WriteLine("trees. The trail opens into a small glade, with a giant sprawling");
                Console.WriteLine("willow next to a small pool. The water at the pool is cool and clear.");
                Console.WriteLine("*******************************************************************");
                Console.WriteLine();
            }
            else if (previousLocation == "WestWoods")
            {
                Console.WriteLine("*******************************************************************");
                Console.WriteLine("You follow the path from the woods east into the forest the light from");
                Console.WriteLine("above trees dances on the forest floor. The trail opens into a small");
                Console.WriteLine("glade, with a giant sprawling willow next to a small pool. The water");
                Console.WriteLine("at the pool is cool and clear.");
                Console.WriteLine("*******************************************************************");
                Console.WriteLine();
            }

            previousLocation = "NorthWoods";

            while (true)
            {
                Console.Write("Command: ");
                string response = Console.ReadLine();
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
                    Map.Clearing();
                }
                else if (response.ToLower() == "north")
                {
                    
                }
                else if (response.ToLower() == "west")
                {
                    Map.WestWoods();
                }
                else if (response.ToLower() == "east")
                {
                    
                }
                else if (response.ToLower() == "inspect")
                {
                    Console.Beep(800, 40);
                    Console.WriteLine("*******************************************************************");
                    Console.WriteLine("You see a large willow with hanging branches. It sits next to a small");
                    Console.WriteLine("pool. To the north the path winds around the tree into more woods.");
                    Console.WriteLine("To the west is another forest path. There is nothing to the east.");
                    Console.WriteLine("*******************************************************************");
                }
                else if (response.ToLower() == "inspect tree")
                {
                    Console.Beep(800, 40);
                    Console.WriteLine("*******************************************************************");
                    Console.WriteLine("You give the tree a closer look. Moss grows along the base and trunk");
                    Console.WriteLine("of it which is as wide as three or four trees. It looks old and ancient");
                    Console.WriteLine("The branches dip so low they kiss the pool occasionally, sending soft");
                    Console.WriteLine("ripples on its surface. A small yellow bird lands on a branch and");
                    Console.WriteLine("looks at you curiously. It sings a quiet sound that strangely sounds");
                    Console.WriteLine("like words.");
                    Console.WriteLine("*******************************************************************");
                }
                else if (response.ToLower() == "inspect pool")
                {
                    Console.Beep(1100, 40);
                    Console.Beep(1000, 100);
                    Console.Beep(1100, 40);
                    Console.Beep(900, 100);
                    Console.Beep(1200, 40);
                    Console.WriteLine("*******************************************************************");
                    Console.WriteLine("You walk closer to the base of the tree to look into the pool. Around ");
                    Console.WriteLine("the pool small flowers and mushrooms sit. They look pristine and untouched.");
                    Console.WriteLine("You gaze into the pool, it is so clear that you can see straight to the");
                    Console.WriteLine("bottom. There is a small gold coin sitting among the pebbles and rocks.");
                    Console.WriteLine("*******************************************************************");
                }
                else if (response.ToLower() == "talk bird" || (response.ToLower() == "talk to bird"))
                {
                    Dialogue.SmallBird();
                }
                else
                {
                    Console.Beep(200, 100);
                    Console.WriteLine("I do not understand that command.");
                }
            }
        }

        private static void WestWoods()
        {
            if (previousLocation == "CliffFace")
            {
                Console.Beep(800, 40);
                Console.Clear();
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
                Console.Beep(800, 40);
                Console.Clear();
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
                string response = Console.ReadLine();
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
            Console.Beep(800, 40);
            Console.Clear();
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
                string response = Console.ReadLine();

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
            Console.Beep(800, 40);
            Console.Clear();
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
                string response = Console.ReadLine();
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
    }
}
