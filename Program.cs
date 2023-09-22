using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using TwistedFizzBuzz;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a list of numbers separated by commas:");
        string input = Console.ReadLine();

        Console.WriteLine("Enter the number of divisors and tokens:");
        int n = int.Parse(Console.ReadLine());

        List<int> divisors = new List<int>();
        List<string> tokens = new List<string>();

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Enter divisor {i + 1}:");
            int divisor = int.Parse(Console.ReadLine());
            divisors.Add(divisor);

            Console.WriteLine($"Enter token {i + 1}:");
            string token = Console.ReadLine();
            tokens.Add(token);
        }

        List<string> results = FizzBuzzCalculator.CalculateFizzBuzz(input, divisors, tokens);

        Console.WriteLine("FizzBuzz Results:");
        foreach (string result in results)
        {
            Console.WriteLine(result);
        }
    }
}