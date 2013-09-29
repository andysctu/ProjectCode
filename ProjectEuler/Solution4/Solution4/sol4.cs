using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solution4
{
    class Program
    {
        static void Main()
        {
            int palindrome = 0;
            for (int x = 100; x < 1000; x++)
            {
                for (int y = 100; y < 1000; y++)
                { 
                    int z = x * y;
                    int left = z;
                    int rev = 0;
                    int r;
                    while (left > 0)
                    {
                        r = left % 10;
                        rev = rev * 10 + r;
                        left = left / 10; 
                    }
                    if (rev == z && rev > palindrome)
                    {
                        palindrome = rev;
                        Console.WriteLine(palindrome);
                    }
                    
                }

            }
            Console.WriteLine("The largest palidrome that is a product of two 3-digit numbers is {0}", palindrome);
            Console.WriteLine("Press enter to exit");
            Console.Read();


            
        }
    }
}
