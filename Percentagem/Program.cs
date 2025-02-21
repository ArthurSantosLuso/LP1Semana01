using System;

namespace Percentagem
{
    public class Program
    {
        private static void Main(string[] args)
        {
            float valor1 = float.Parse(Console.ReadLine());
            float valor2 = float.Parse(Console.ReadLine());
            float valor3 = float.Parse(Console.ReadLine()); 
            float valor4 = float.Parse(Console.ReadLine());

            Console.WriteLine($"{valor1:P2}\n{valor2:P2}\n{valor3:P2}\n{valor4:P2}");
        }
    }
}
