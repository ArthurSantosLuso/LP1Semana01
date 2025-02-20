using System;
using System.Text;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string stringTest1 = "\'";
            string stringTest2 = "\\";
            string stringTest3 = "\t";
            string stringTest4 = "\"";
            string stringTest5 = "\u2713";
            string stringTest6 = "\u1BD6";
            string stringTest7 = "\u2126";

            Console.WriteLine($"{stringTest1}\n{stringTest2}\n{stringTest3}");
            Console.WriteLine($"{stringTest4}\n{stringTest5}\n{stringTest6}");
            Console.WriteLine($"{stringTest7}");

        }
    }
}
