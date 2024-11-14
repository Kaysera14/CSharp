using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            int i = 0;

            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }*/

            Console.Write("Enter the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int answer = a * b;
            Console.Write("What the value of " + a + "x" + b + "?");
            Console.WriteLine();
            int actualAnswer = 0;

            /*while (answer != actualAnswer)
            {
                Console.Write("Enter your answer: ");
                string answerInput = Console.ReadLine();
                actualAnswer = Convert.ToInt32(answerInput);

                if (answer != actualAnswer) // != used to indicate not equal
                {
                    Console.WriteLine("Close but it was wrong!");
                    Console.WriteLine();
                }
            }*/

            do // this will always loop once and check the condition, a while loop will depende always on the condition
            {
                Console.Write("Enter your answer: ");
                string answerInput = Console.ReadLine();
                actualAnswer = Convert.ToInt32(answerInput);

                if (answer != actualAnswer) // != used to indicate not equal
                {
                    Console.WriteLine("Close but it was wrong!");
                    Console.WriteLine();
                }
            } while (answer != actualAnswer);

            Console.WriteLine("Well done!");

            Console.ReadLine();
        }
    }
}
