using System;

class Program
{
    static void Main()
    {
        for (int i = -20; i <= 127; i++)
        {
            string output = string.Empty;

            if (i % 5 == 0)
            {
                output += "Fizz";
            }

            if (i % 9 == 0)
            {
                output += "Buzz";
            }

            if (i % 27 == 0)
            {
                output += "Bar";
            }

            if (string.IsNullOrEmpty(output))
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine(output);
            }
        }
    }
}
