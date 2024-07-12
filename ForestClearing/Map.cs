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
        //public static void PlayerLocation(int x, int y)

        //{
        //    if (x == 0 && y == 0)
        //        Map.Clearing();
        //    else if (x == -1 && y == 0)
        //        Map.SouthWoods();
        //    else if (x == -2 && -y == 0)
        //        Map.SouthSouthWoods();
        //}
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

        private static void EndlessSwamp()
        {
            Console.Beep(800, 40);
            Console.Clear();
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("                                                                   ");
            Console.WriteLine("                                                                   ");
            Console.WriteLine("                                                                   ");
            Console.WriteLine("                                                                   ");
            Console.WriteLine("                                                                   ");
            Console.WriteLine("                                                                   ");
            Console.WriteLine();
            Console.WriteLine("*******************************************************************");

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

        private static void CliffFace()
        {
            throw new NotImplementedException();
        }

        private static void NorthWoods()
        {
            
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
