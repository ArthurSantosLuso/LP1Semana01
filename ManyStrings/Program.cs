using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Var string for exercice 4
            string stringTest1 = "\'";
            string stringTest2 = "\\";
            string stringTest3 = "\t";
            string stringTest4 = "\"";
            string stringTest5 = "\u2713";
            string stringTest6 = "\u1BD6";
            string stringTest7 = "\u2126";

            // var strings for exercice 5s
            // concatination string variables
            string aux = "vanilla";
            string copyrightIcon = "\u00AE";
            string stringTest8 = "Arthur" + 2;
            string stringTest9 = "I love " + aux + " Coca Cola" + copyrightIcon;

            // interpolation string varibles
            string heartIcon = "\u2665 ";
            string loveMessage = $"I {heartIcon} my GF";
            string stringTest10 = $"My favorite ice cream flavour is {aux}";

            Console.WriteLine($"{stringTest1}\n{stringTest2}\n{stringTest3}");
            Console.WriteLine($"{stringTest4}\n{stringTest5}\n{stringTest6}");
            Console.WriteLine($"{stringTest7}");

            Console.WriteLine($"{stringTest8}\n{stringTest9}"); 

            Console.WriteLine(loveMessage);
            Console.WriteLine(stringTest10);

        }
    }
}
