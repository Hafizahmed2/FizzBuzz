using System;
using System.Collections.Generic;
using System.Linq;

namespace TwistedFizzBuzz
{
    public class FizzBuzzCalculator
    {
        public static List<string> CalculateFizzBuzz(string input, List<int> divisors, List<string> tokens)
        {
            if (divisors.Count != tokens.Count)
            {
                throw new ArgumentException("The number of divisors must match the number of tokens.");
            }

            List<string> results = new List<string>();

            // Split the input by commas and trim any whitespace
            string[] numbers = input.Split(',').Select(x => x.Trim()).ToArray();

            foreach (string numberStr in numbers)
            {
                if (int.TryParse(numberStr, out int number))
                {
                    string fizzBuzzResult = CalculateSingleFizzBuzz(number, divisors, tokens);
                    results.Add($"{fizzBuzzResult}");
                }
                else
                {
                    results.Add($"{numberStr}: Invalid input (not an integer)");
                }
            }

            return results;
        }

        public static string CalculateSingleFizzBuzz(int number, List<int> divisors, List<string> tokens)
        {
            string result = "";

            for (int i = 0; i < divisors.Count; i++)
            {
                if (number % divisors[i] == 0)
                {
                    result += tokens[i];
                }
            }

            if (string.IsNullOrEmpty(result))
            {
                return number.ToString();
            }
            else
            {
                return result;
            }
        }

    }
}
