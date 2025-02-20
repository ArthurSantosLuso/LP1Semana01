using System;
using System.Reflection;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Ask for a interger number
            Console.WriteLine("Insert a interger number: ");
            int valueInserted1 = int.Parse(Console.ReadLine());

            // Ask for a real number
            Console.WriteLine("Insert a real number: ");
            float valueInserted2 = float.Parse(Console.ReadLine());
            
            // Print the adding of both inputs
            Console.WriteLine($"{valueInserted1 + valueInserted2}");

        }
    }
}
