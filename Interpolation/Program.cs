using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Toni";
            int age = 28;

            Console.WriteLine("Your name is " + name + " your age is " + age);
            Console.WriteLine($"Your name is {name} your age is {age}"); // used curly braces and a dollar sign at the start to interpolate the string

            Console.ReadLine();
        }
    }
}
