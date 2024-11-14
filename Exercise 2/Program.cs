using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    internal class Program
    {
        /*
         * Create & initalise two ints
         * Make a variable to work out the remainder
         * Output remainder to the screen
         * Change the first int variable to another number
            * and recalculate the remainder
            * output new remainder to the screen
         */
        static void Main(string[] args)
        {
            int a = 10;
            int b = 2;
            int remainder = a % b;
            Console.WriteLine(remainder);

            a = 11;
            remainder = a % b;
            Console.WriteLine(remainder);

            Console.ReadLine();
        }
    }
}
