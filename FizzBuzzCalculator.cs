using System;
using System.Collections.Generic;
using System.Linq;

namespace TwistedFizzBuzz
{
    public class FizzBuzzCalculator
    {
        public static List<string> CalculateFizzBuzz(string input)
        {
            List<string> results = new List<string>();


            if (input.Contains('-'))
            {
                // Split the input by hyphen to get the range
                string[] range = input.Split('-').Select(x => x.Trim()).ToArray();
                string endRange = range[1].Replace(",", "");
                if (range.Length != 2 ||
                    !int.TryParse(range[0], out int start) ||
                    !int.TryParse(endRange, out int end))
                {
                    results.Add("Invalid range format. Please use 'start-end'.");
                    return results;
                }

                if (start > end)
                {
                    results.Add("Start of the range should be less than or equal to the end.");
                    return results;
                }

                for (int number = start; number <= end; number++)
                {
                    string fizzBuzzResult = CalculateSingleFizzBuzz(number);
                    results.Add($"{fizzBuzzResult}");
                }
            }
            else
            {
                string[] numbers = input.Split(',').Select(x => x.Trim()).ToArray();

                foreach (string numberStr in numbers)
                {
                    if (int.TryParse(numberStr, out int number))
                    {
                        string fizzBuzzResult = CalculateSingleFizzBuzz(number);
                        results.Add($"{fizzBuzzResult}");
                    }
                    else
                    {
                        results.Add($"{numberStr}: Invalid input (not an integer)");
                    }
                }
            }

            return results;
        }

        public static string CalculateSingleFizzBuzz(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                return "Fizz";
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return number.ToString();
            }
        }
    }
}
