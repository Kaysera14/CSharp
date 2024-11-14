using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double age = 23; // if u are using a division, use a double
            // + - * /
            age /= 10; // 2,3 -> 2
            Console.WriteLine(age);

            string name = "Aba";
            name += " is programming!"; // use += to concatenate
            Console.WriteLine(name);

            char ch = 'a';
            ch += 'b'; // sums up unicodes
            Console.WriteLine(ch);

            int i = 0;
            Console.WriteLine(i++); //prints i and then adds 1
            Console.WriteLine(i);

            int b = 0;
            Console.WriteLine(++b); // adds 1 and then print b

            Console.ReadLine();
        }
    }
}
