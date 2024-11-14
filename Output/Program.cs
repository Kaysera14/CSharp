using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Output
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // \t is used for tabs
            // \n is used for new lines
            // \" is used to add quotations
            // \\ is used to add a \ since it is an escape character

            string speech = "He said \"something\""; // now it will display "something" when printed

            string path = "D:\\Programacion\\C#\\freeCodeCamp\\MyFirstProject\\Output";
            Console.WriteLine(path);
            Console.WriteLine(speech);
            // $ is used to interpolate variables like $"Your name is {name}"
            // + is used to concatenate like "Your name is " + name
            // @ is a verbatim used to negate escape characters

            path = @"D:\\Programacion\\C#\\freeCodeCamp\\MyFirstProject\\Output";
            Console.WriteLine(path);

            path = @"D:\Programacion\C#\freeCodeCamp\MyFirstProject\Output" + "\n"; // this will add a new line (\n) since it doesnt have an @ at the start
            Console.WriteLine(path);

            string name = @"Hello ""someone""";
            Console.WriteLine(name);

            name = "Hello 'someone'";
            Console.WriteLine(name);


            Console.ReadLine();
        }
    }
}
