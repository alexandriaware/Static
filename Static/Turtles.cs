using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Turtles
    {
        static int turtleCount; // <-- static doesn't need a property

        public Turtles()
        {
            turtleCount++;
        }

        public static void WarCry()
        {
            Console.WriteLine("We are an army of " + turtleCount + " turtles!!");
        }



    }
}
