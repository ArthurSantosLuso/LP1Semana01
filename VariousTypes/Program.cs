using System;

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Variables declaration area
            int interger = 5;
            long longInterger = 1000000;
            short shortInterger = 50;
            sbyte oneByteInterger = 12;

            char charUniCode1 = '\u00A9', charUniCode2 = '\u00B1', charUniCode3 = '\u02AC';

            float floatVarExample = 1.1f;
            double doubleVarExample = 5.55;
            decimal decimalVarExample = 8.566M; 

            bool varVerdadeira = true;
            bool varFalsa = false;

            // Printing int's variables
            Console.WriteLine($"{interger}\n{longInterger}\n{shortInterger}\n{oneByteInterger}");

            // Printing char's variables
            Console.WriteLine($"{charUniCode1}\n{charUniCode2}\n{charUniCode3}");

            // Printing real's variables
            Console.WriteLine($"{floatVarExample}\n{doubleVarExample}\n{decimalVarExample}");

            // Printing bool's variables
            Console.WriteLine($"{varVerdadeira}\n{varFalsa}");


        }
    }
}
