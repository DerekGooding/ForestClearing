using MiniProject;
using System.Collections.Concurrent;
using System.Xml.Linq;

namespace ForestClearing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INTRO
            MainMethod.Intro();
            string playerName = MainMethod.PlayerName();

            Map.Clearing();



            //HELP

            ///

            //CLEARING
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            Console.WriteLine("You take a quick look around the clearing.");
            Console.WriteLine("There isnt much going on, a small creek runs east from west. The sky is cloudless.");
            Console.WriteLine("To the North you see a path through the trees. You look West and see that the trees sit near a cliff face, with a small trail leading to the cliff.");
            Console.WriteLine("The creek heading east seems to follow a very small break in the trees, but it looks like a tight fit.");
            Console.WriteLine("As you turn around to see south of you, a large crash is heard.");
            Console.WriteLine("There is a large cloud of dust coming from somewhere deep in the woods. You can see an overgrown but accessible trail...");
            Console.ReadLine();

        }
    }
}
