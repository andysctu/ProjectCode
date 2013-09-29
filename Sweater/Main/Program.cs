using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweater
{
    class Program
    {
        static void Main(string[] args)
        {
            //Call constructor to create new Sweater s1, s2, with appropriate fields
            Sweater s1 = new Sweater("Turtleneck", "Neon-Brown", 22, 99.99, true);
            Sweater s2 = new Sweater("V-neck", "Red", 8, 9.93, false);


            //Call method to display all fields of s1, then s2
            Console.WriteLine("Sweater s1");
            s1.DisplayToConsole();

            Console.WriteLine("Sweater s2");
            s2.DisplayToConsole();
        }
    }
}
