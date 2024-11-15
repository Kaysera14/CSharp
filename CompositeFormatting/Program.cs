using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeFormatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Toni";
            int age = 28;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);

            Console.WriteLine();

            Console.WriteLine("Name: " + name + "\nAge: " + age); // uses \n to add a new line

            Console.WriteLine("Your name is " + name + ", and your age is " + age);

            Console.WriteLine("Your name is {0}, and your age is {1}", name, age); // used curly braces to represent data, doesn't use concatenation
            Console.WriteLine("Name: {0}\nAge: {1}", name, age);

            Console.ReadLine();
        }
    }
}
