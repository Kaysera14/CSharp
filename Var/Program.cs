using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // use var when it's very obvious what the variable will be, to avoid errors

            //int age = -28;
            var age = 28;
            Console.WriteLine(age);

            //long bigNumber = -900000000L;
            var bigNumber = -900000000L;
            Console.WriteLine(bigNumber);

            var negative = -55.2D;
            Console.WriteLine(negative);

            var precision = 5.000001F;
            Console.WriteLine(precision);

            var money = 14.99M;
            Console.WriteLine(money);

            var name = "Toni";
            Console.WriteLine(name);

            var letter = "a";
            Console.WriteLine(letter);

            Console.ReadLine();
        }
    }
}
