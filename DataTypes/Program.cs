using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int x = 10;
            //int y = 20;
            //int z = 30;

            int x = 10, y = 20, z = 30;

            int age = -23; // value initialization
            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue); // max number in int
            Console.WriteLine(int.MinValue); // min number in int

            long bigNumber = -900000000L; // if the number is INT32 put an L at the end to make it a Long number (INT64)
            Console.WriteLine(bigNumber);
            Console.WriteLine(long.MaxValue); // max number in long
            Console.WriteLine(long.MinValue); // min number in long

            double negative = -55.2D; // to make sure it's a double, you can add a D at the end of the number
            Console.WriteLine(negative);
            Console.WriteLine(double.MaxValue); // max number in double up to e308
            Console.WriteLine(double.MinValue); // min number in double up to -e308

            float precision = 5.000001F; // to make sure it's a float, you can add an F at the end of the number
            Console.WriteLine(precision);
            Console.WriteLine(float.MaxValue); // max number in float up to e38
            Console.WriteLine(float.MinValue); // min number in float up to -e38

            decimal money = 14.99M; //to make sure it's a decimal, you can add an M at the end of the number
            Console.WriteLine(money);
            Console.WriteLine(decimal.MaxValue); // max number in decimal
            Console.WriteLine(decimal.MinValue); // min number in decimal

            age = 50; // new value for age
            Console.WriteLine(age);

            Console.ReadLine();
        }
    }
}
