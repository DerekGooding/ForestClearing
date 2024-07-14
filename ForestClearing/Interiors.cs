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

        }
    }
}
