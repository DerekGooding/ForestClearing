using MiniProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestClearing
{
    internal class MainMethod
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
            Console.WriteLine("INVENTORY - takes you to the inventory menu.");
            Console.WriteLine("NORTH, SOUTH, EAST, or WEST - Moves you in the direction of choice");
            Console.WriteLine("to different destinations.");
            Console.WriteLine("USE (item) - uses an item of choice from your inventory or environment");
            Console.WriteLine("on the word around you but be careful and think. Items can be wasted that");
            Console.WriteLine("you might need later on!");
        }
        public static string PlayerName()
        {
            string name = "";
            bool playerNameValid = false;
            while (!playerNameValid)
            {
                
                Console.Write("What is your name: ");
                name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("I do not understand that.");
                }
                else if (name.ToLower() == "help")
                {
                    MainMethod.Help();
                }
                else
                {
                    playerNameValid = true;                    
                }
             
            }
            return name;
        }
        public static List<string> InitInventory()
        {
            List<string> inventory = new List<string>();
            inventory.Add("Pickle");
            inventory.Add("dirty penny");
            return inventory;   
        }
        public static void DisplayInventory(List<string> inventory)
        {
            foreach (string item in inventory)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}
