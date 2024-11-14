using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Your name is " + name + " and your age is " + age);*/
            // == > >= <= !=

            /*if (age >= 18 && age <= 25)
            { 
                Console.WriteLine("You are between 18 and 25");
            }
            else if (age >= 26)
            {
                Console.WriteLine("You are 26 or older");
            }
            */

            /*if (age < 0 || age > 150)
            {
                Console.WriteLine("Invalid age!");
            } else
            {
                if (age >= 18 && age <= 25)
                {
                    Console.WriteLine("You are between 18 and 25");
                }
                else if (age >= 26)
                {
                    Console.WriteLine("You are 26 or older");
                }
            }*/

            Console.Write("Enter the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int answer = a * b;
            Console.Write("Value of " + a + "x" + b + ": ");
            int actualAnswer = Convert.ToInt32(Console.ReadLine());

            if (answer == actualAnswer) // != used to indicate not equal
            {
                Console.WriteLine("Congrats");
            } else
            {
                Console.WriteLine("The correct answer was: " + answer);
            }

            Console.ReadLine();
        }
    }
}
