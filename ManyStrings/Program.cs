using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // var for excercice 6
            double xx = 1.23456;
            int ii = 19;

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

            // priting strings for exercice 4
            Console.WriteLine($"{stringTest1}\n{stringTest2}\n{stringTest3}");
            Console.WriteLine($"{stringTest4}\n{stringTest5}\n{stringTest6}");
            Console.WriteLine($"{stringTest7}");
            
            // priting strings for exercice 5
            Console.WriteLine($"{stringTest8}\n{stringTest9}"); 
            Console.WriteLine(loveMessage);
            Console.WriteLine(stringTest10);

            // priting var for exercice 6
            Console.WriteLine($"{xx:f2}\n{xx:p1}");
            Console.WriteLine($"{ii:X}\n{ii:C}"); 
        }
    }
}
