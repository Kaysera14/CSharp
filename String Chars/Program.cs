using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Aba"; //required speech marks for names
            char letter = 'a'; // char needs  quotations mark

            Console.Write("Your name is: "); // only using Write makes everything a single line
            Console.Write(name);

            Console.WriteLine(); // sing WriteLine makes a linejump
            Console.WriteLine(letter);

            Console.Write("Your name is: " + name); // you can use + to concatenate

            Console.ReadLine();
        }
    }
}
