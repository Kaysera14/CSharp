using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Program
    {
        /*
         * Ask the user for a number for the table
         * Write a for loop to print X times table
         */
        static void Main(string[] args)
        {
            Console.Write("Enter a number to see the times table: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", num, i, i * num);
            }

            Console.ReadLine();
        }
    }
}
