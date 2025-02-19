using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        ////Simple Version
        string name = "Vasileios";
        int sumhard = name.Where(char.IsLetter).Sum(c => char.ToLower(c) - 'a' + 1);
        Console.WriteLine($"Hello my name is '{name}' and the sum of the letters in my name is: {sumhard}");
        Console.WriteLine(".........................................................................."); Console.WriteLine();

        //Fancy Version
        Console.WriteLine("Welcome! This program calculates the sum of letters in a name.");
        Console.WriteLine("................................................................");
        Console.WriteLine("Only English alphabet characters (A-Z, a-z) will be processed.");
        Console.WriteLine("................................................................");
        Console.WriteLine("Example: A=1, B=2, F=6 ..., Z=26.");
        Console.WriteLine("................................................................");
        Console.WriteLine("Type 'exit' to quit this program -- The sum of 'exit' is 58 btw.");
        Console.WriteLine("................................................................");
        Console.WriteLine(); Console.WriteLine();

        while (true)
        {
            Console.Write("Enter a name: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid input. Please enter something.");
                Console.WriteLine();
                continue;
            }

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Exiting the program...");
                break;
            }

            if (input.Any(c => !((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || char.IsWhiteSpace(c))))
            {
                Console.WriteLine("Note: Invalid characters detected and excluded from the calculation.");
            }

            int sum = input
                .Where(c => (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                .Sum(c => char.ToLower(c) - 'a' + 1);

            Console.WriteLine($"The sum of the letters in '{input}' is: {sum}");
            Console.WriteLine();
        }
    }
}
