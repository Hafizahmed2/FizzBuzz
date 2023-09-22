using System;
using TwistedFizzBuzz;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a list of numbers separated by commas:");
        string input = Console.ReadLine();

        List<string> results = FizzBuzzCalculator.CalculateFizzBuzz(input);

        Console.WriteLine("FizzBuzz Results:");
        foreach (string result in results)
        {
            Console.WriteLine(result);
        }
    }
}