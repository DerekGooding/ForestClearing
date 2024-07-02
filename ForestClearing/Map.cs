using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestClearing
{
    internal class Map
    {
        public static void Clearing()
        {
            while (true)
            {
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
        public static void SouthWoods()
        {
            Console.WriteLine("******************************************************************");
            Console.WriteLine("You make your way south through the overgrown trail. The deeper you");
            Console.WriteLine("go the tighter the trail gets, and branches start to snag at you.");
            Console.WriteLine("As you struggle along you catch sight of a smaller open patch. There");
            Console.WriteLine("is something shuffling around ahead. There is nothing to the east");
            Console.WriteLine("or west of you. Your choices are to continue south or move north");
            Console.WriteLine("back to the clearing.");
        }
        public static void SouthSouthWoods()
        {
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("As you continue along the path and into the open patch you catch a");
            Console.WriteLine("proper look at the thing shuffling around, and what you realize was");
            Console.WriteLine("The source of all that commotion. Whats in front of you is a large,");
            Console.WriteLine("bear-like creature. With 8 inch claws and razor sharp fangs. At its");
            Console.WriteLine("feet is a small unidentifyable, but very much dead animal. There is");
            Console.WriteLine("no path out but back from North. The creature turns to you, its");
            Console.WriteLine("eyes black and skin both furry and scaly at the same time. It roars");
            Console.WriteLine("and charges you.");
        }

    }
}
