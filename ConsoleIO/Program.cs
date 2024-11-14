using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, my name is Aba!");

            Console.Write("Enter your name: "); // use Write to not push into another line
            string name = Console.ReadLine();
            //Console.WriteLine(name);

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(age);

            Console.WriteLine();
            Console.Write("Your name is " + name + " and your age is " + age);
            //Console.Write(name);
            //Console.Write(" and your age is ");
            //Console.Write(age);

            Console.ReadLine();
        }
    }
}
