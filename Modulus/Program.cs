using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = 10;
            int secondNum = 3;

            Console.WriteLine(firstNum % secondNum); // shows the remainder, 10/3 = 9, 10-9 = 1
            // if divided by 2 and the remainder is a multiple of 10 or 0, you get an even number, else is odd

            Console.ReadLine();
        }
    }
}
