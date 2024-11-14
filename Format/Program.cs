using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Format
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value = 1000D / 12.34D; // the D is used to indicate that it's a Double, else it will process it as an int and information will be lost

            //Console.WriteLine(string.Format("{0} {1}", value, 1000)); this pattern will put value at place 0 and 1000 at place 1

            Console.WriteLine(value);
            Console.WriteLine(string.Format("{0:0}", value)); // this pattern will round up and show no decimals
            Console.WriteLine(string.Format("{0:0.#}", value)); // this pattern will round and show only one decimals, if it's .0 it will get rid of it
            Console.WriteLine(string.Format("{0:0.00}", value)); // this pattern will round and show only two decimals

            double money = 10D / 3D; //3.33333333

            Console.WriteLine(money);
            Console.WriteLine(string.Format("{0:0.00}EUR", money));
            Console.WriteLine(money.ToString("C")); // this is used to represent currency based on your location
            Console.WriteLine(money.ToString("C0"));
            Console.WriteLine(money.ToString("C1"));
            Console.WriteLine(money.ToString("C2"));

            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); // used to specify a certain location


            Console.ReadLine();
        }
    }
}
