using System;

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int interger = 5;
            long longInterger = 1000000;
            short shortInterger = 50;
            sbyte oneByteInterger = 12;

            char charUniCode1 = '\u00A9', charUniCode2 = '\u00B1', charUniCode3 = '\u02AC';

            Console.WriteLine($"{interger}\n{longInterger}\n{shortInterger}\n{oneByteInterger}");

            Console.WriteLine($"{charUniCode1}\n{charUniCode2}\n{charUniCode3}");


        }
    }
}
