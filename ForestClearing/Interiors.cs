using MiniProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestClearing
{
    internal class Interiors
    {
        static List<string> inventory = MainMethod.InitInventory();
        internal static void Template()
        {
            Console.Beep(800, 40);
            Console.Clear();
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
                string response = Console.ReadLine();
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
            Console.Beep(800, 40);
            Console.Clear();
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
                string response = Console.ReadLine();
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
            Console.Beep(800, 40);
            Console.Clear();
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
                string response = Console.ReadLine();
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

        public static void SwampMaze(int swampCount = 0)
        {
            Console.Beep(800, 40);
            Console.Clear();
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
                    if (swampCount == 3)
                    {
                        Map.SwampIsland();
                        swampFinished = true; 
                    }
                    else
                    {
                        Console.Beep(800, 40);
                        Console.Clear();
                        Console.WriteLine("*******************************************************************");
                        Console.WriteLine("You move South and are surrounded by swamp");
                        Console.WriteLine("*******************************************************************");
                        swampCount = SwampLogic(0); 
                    }
                }
                else if (response.ToLower() == "north")
                {
                    if (swampCount == 0)
                    {
                        Console.Beep(800, 40);
                        Console.Clear();
                        Console.WriteLine("*******************************************************************");
                        Console.WriteLine("You move North and are surrounded by swamp");
                        Console.WriteLine("*******************************************************************");
                        swampCount = SwampLogic(1); // Update swampCount
                    }
                    else
                    {
                        Console.Beep(800, 40);
                        Console.Clear();
                        Console.WriteLine("*******************************************************************");
                        Console.WriteLine("You move North and are surrounded by swamp");
                        Console.WriteLine("*******************************************************************");
                        swampCount = SwampLogic(0); // Reset swampCount
                    }
                }
                else if (response.ToLower() == "west")
                {
                    if (swampCount == 1)
                    {
                        Console.Beep(800, 40);
                        Console.Clear();
                        Console.WriteLine("*******************************************************************");
                        Console.WriteLine("You move West and are surrounded by swamp");
                        Console.WriteLine("*******************************************************************");
                        swampCount = SwampLogic(2); 
                    }
                    else if (swampCount == 2)
                    {
                        Console.Beep(800, 40);
                        Console.Clear();
                        Console.WriteLine("*******************************************************************");
                        Console.WriteLine("You move West and are surrounded by swamp");
                        Console.WriteLine("*******************************************************************");
                        swampCount = SwampLogic(3); 
                    }
                    else
                    {
                        Console.Beep(800, 40);
                        Console.Clear();
                        Console.WriteLine("*******************************************************************");
                        Console.WriteLine("You move West and are surrounded by swamp");
                        Console.WriteLine("*******************************************************************");
                        swampCount = SwampLogic(0); 
                    }
                }
                else if (response.ToLower() == "east")
                {
                    Console.Beep(800, 40);
                    Console.Clear();
                    Console.WriteLine("*******************************************************************");
                    Console.WriteLine("You move East and are surrounded by swamp");
                    Console.WriteLine("*******************************************************************");
                    swampCount = SwampLogic(0); 
                }

                if (swampFinished)
                {
                    break;
                }
            }
        }
        public static int SwampLogic(int swampAdd)
        {
            return swampAdd;
        }
    }
}
