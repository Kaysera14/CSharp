using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    internal class Program
    {
        /*
         * Define a variable to hold your name
         * Define a variable to hold your phone number
         * Define a variable to hold your age
         * Print variables line-by-line to the screen
         * Extra: define variables using the var keyword
         */
        static void Main(string[] args)
        {
            var name = "Toni";
            var phoneNumber = "0123456789";
            var age = 28;

            Console.WriteLine("Hi, my name is: " + name);
            Console.WriteLine("My phone number is: " + phoneNumber);
            Console.WriteLine("My age is: " + age);

            Console.ReadLine();
        }
    }
}
