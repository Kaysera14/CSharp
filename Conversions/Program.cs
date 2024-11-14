using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // . is used in decimal in other countries, meanwhile in Spain you need to use , to represent decimals
            string textAge = "-23";
            int age = Convert.ToInt32(textAge); // converts a string to an int
            Console.WriteLine(age);

            string textBigNumber = "-900000000";
            long bigNumber = Convert.ToInt64(textBigNumber);
            Console.WriteLine(bigNumber);

            string textNegative = "-55,2";
            double negative = Convert.ToDouble(textNegative);
            Console.WriteLine(negative);

            string textPrecision = "5,000001";
            float precision = Convert.ToSingle(textPrecision);
            Console.WriteLine(precision);

            string textMoney = "14,99";
            decimal money = Convert.ToDecimal(textMoney);
            Console.WriteLine(money);

            Console.ReadLine();
        }
    }
}
