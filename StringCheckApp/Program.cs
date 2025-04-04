using System;
using StringLibrary;

namespace StringCheckApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Console.WriteLine(input.StartsWithUpperCase()
                ? "✅ Starts with uppercase letter."
                : "❌ Does NOT start with uppercase letter.");
        }
    }
}
