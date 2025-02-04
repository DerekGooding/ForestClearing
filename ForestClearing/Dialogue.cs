﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestClearing
{
    internal class Dialogue
    {
        private static bool metHintus = false;
        private static bool knowsBird = false;
        public static void PrintHintusDialog(string message)
        {
            Console.Write("Hintus: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void Hintus()
        {

            bool dialogDone = false;
            bool knowsRathbone = false;
            bool romanCitizen = false;
            Console.Beep(800, 40);
            Console.Clear();
            if (!metHintus)
            {
                Console.WriteLine("*******************************************************************");
                Console.WriteLine("You cough to get the strange mans attention. He turns quickly and");
                Console.WriteLine("jumps back surprised, knocking the brazier over. He scrambles to pick");
                Console.WriteLine("it back up and burns his hands in the process. He stands there blowing");
                Console.WriteLine("air on his hands and begins to speak.");
                Console.WriteLine("*******************************************************************");
                Console.Write("Hintus: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Err hello there citizen. I am Hintus Augustus Maximus. You must be");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine("1 - How did you know my name?");
                Console.WriteLine("2 - You seem very interested in Rome...");
                Console.WriteLine("Leave");
                Console.WriteLine("Command: ");
                metHintus = true;
            }
            else
            {
                Console.WriteLine("*******************************************************************");
                Console.WriteLine("Hintus greets you warmly with a Roman salute. You feel quite uncomfortable");
                Console.WriteLine("when he does it.");
                Console.WriteLine("*******************************************************************");
                Console.WriteLine();
                Console.WriteLine("1 - How did you know my name?");
                Console.WriteLine("2 - You seem very interested in Rome...");
                Console.WriteLine("Leave");
                Console.WriteLine("Command: ");
            }
            do
            {
                string response = Console.ReadLine();
                switch (response.ToLower())
                {
                    case "leave":

                        dialogDone = true;
                        Console.Clear();
                        Console.WriteLine("*******************************************************************");
                        Console.WriteLine("You are back in the Hut.");
                        Console.WriteLine("*******************************************************************");
                        Console.WriteLine();
                        break;

                    case "1":
                        PrintHintusDialog("I am great friends with Rathbone the Wizard.");
                        knowsRathbone = true;
                        break;

                    case "2":
                        PrintHintusDialog("I am not just interested in Rome, I am a Roman citizen.");
                        romanCitizen = true;
                        break;

                    case "3":
                        if (knowsRathbone)
                        {
                            PrintHintusDialog("Rathbone is a powerful wizard who lives in the northern mountains.");
                        }
                        else
                        {
                            Console.WriteLine("That is not a valid choice.");
                        }
                        break;
                    case "4":
                        if (romanCitizen)
                        {
                            PrintHintusDialog("Rathbone is a powerful wizard who lives in the northern mountains.");
                        }
                        else
                        {
                            Console.WriteLine("That is not a valid choice.");
                        }
                        break;

                    default:
                        Console.WriteLine("That is not a valid choice.");
                        break;

                }

                if (knowsRathbone)
                {
                    Console.WriteLine("3 - Who is Rathbone?");
                }
                if (romanCitizen)
                {
                    Console.WriteLine("4 - Roman Citizen?");
                }

            } while (!dialogDone);
        }

        internal static void SmallBird()
        {
            List<string> ArturoDialog = new List<string>();
            ArturoDialog.Add("1 - And who are you... my liege ?");
            ArturoDialog.Add("2 - Leave");

            bool dialogDone = false;
            bool knowsArturo = false;

            if (!knowsBird)
            {
                Console.Beep(800, 40);
                Console.Clear();
                Console.WriteLine("*******************************************************************");
                Console.WriteLine("You greet the bird softly and stick out your finger. The bird bites");
                Console.WriteLine("it and begins to speak.");
                Console.WriteLine("*******************************************************************");
                Console.Write("Bird: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Do not touch me, peasant. Among my kind I am a great and powerful");
                Console.WriteLine("King. I will forgive your transgression this time, serf.");
                knowsBird = true;
            }
            else
            {
                Console.Beep(800, 40);
                Console.Clear();
                Console.WriteLine("*******************************************************************");
                Console.WriteLine("The bird sits there and puffs out its chest. It waits patiently on ");
                Console.WriteLine("a branch.");
                Console.WriteLine("*******************************************************************");
            }

            do
            {
                if (!dialogDone)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("1 - And who are you... my liege?");
                    Console.WriteLine("2 - Leave");
                    Console.WriteLine("Command: ");
                    Console.ResetColor();
                }

                string response = Console.ReadLine();
                switch (response.ToLower())
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Arturo: ");
                        PrintBirdDialog("I am the great king Arturo. Leader of the Yellow Feather Coalition. Sire to hundreds of princelings.");
                        PrintBirdDialog("Heir to the North Woods and contender for the South Wood Kingdom. My reach is long and my Harem is endless.");
                        Console.WriteLine();
                        Console.WriteLine("3 - Where did you learn to speak?");
                        knowsArturo = true;
                        break;
                    case "2":
                        dialogDone = true;
                        Console.Clear();
                        Console.WriteLine("*******************************************************************");
                        Console.WriteLine("You are back in the Glade.");
                        Console.WriteLine("*******************************************************************");
                        Console.WriteLine();
                        break;
                    case "3":
                        if (knowsArturo)
                        {
                            PrintBirdDialog("All birds can speak human, to some extent. Great birds like me can do it well.");
                        }
                        else
                        {
                            Console.WriteLine("That is not a valid choice");
                        }
                        break;
                    default:
                        Console.WriteLine("That is not a valid choice.");
                        break;
                }
            } while (!dialogDone);
        }
        private static void PrintBirdDialog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
