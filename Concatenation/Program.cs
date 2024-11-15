using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Toni";
            int age = 28;

            Console.WriteLine("Your name is " + name + " and your age is " + age);

            Console.WriteLine($"Your name is {name} and your age is {age}"); // interpolation
            Console.WriteLine("Your name is {0} and your age is {1}", name, age); // composite formatting

            Console.ReadLine();
        }
    }
}
