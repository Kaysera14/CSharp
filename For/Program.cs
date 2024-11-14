using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What do you want to repeat?: ");
            string message = Console.ReadLine();
            Console.Write("How many times do you want to say " + message + "?: ");
            int loopCounter = Convert.ToInt32(Console.ReadLine());

            if (loopCounter <= 0) {
                Console.WriteLine("Please enter value above 0");
            }
            else
            {
                for (int i = 0; i < loopCounter; i++) // (variable ; condition to loop ; increment)
                {
                    Console.WriteLine(message);
                }
            }

            /*for (int i = 0;i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }*/

            Console.ReadLine();
        }
    }
}
