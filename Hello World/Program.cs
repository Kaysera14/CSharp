using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); // don't need to declare the use of System
            System.Console.WriteLine("Hello World!"); // need to declare the use of System

            Console.ReadLine(); // used to await user input
        }
    }
}
