using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestClearing
{
    internal class Dialogue
    {
        public static void Hintus(string name)
        {
            Console.Beep(800, 40);
            Console.Clear();
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("You cough to get the strange mans attention. He turns quickly and");
            Console.WriteLine("jumps back surpised, knocking the brazier over. He scrambles to pick");
            Console.WriteLine("it back up and burns his hands in the process. He stands there blowing");
            Console.WriteLine("air on his hands and begins to speak.");
            Console.WriteLine("*******************************************************************");
            Console.Write("Hintus: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Err hello there citizen. I am Hintus Agustus Maximus. You must be {name}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("1 - How did you know my name?");
            Console.WriteLine("2 - You seem very interested in Rome...");
            Console.WriteLine("Command: ");
            string response = Console.ReadLine();
        }
    }
}
