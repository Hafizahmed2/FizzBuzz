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

        List<int> divisors = new List<int>();
        List<string> tokens = new List<string>();
        Console.WriteLine("Wait Fetching token");
        var url = "https://rich-red-cocoon-veil.cyclic.app/random";

        var request = WebRequest.Create(url);
        request.Method = "GET";

        using var webResponse = request.GetResponse();
        using var webStream = webResponse.GetResponseStream();

        using var reader = new StreamReader(webStream);
        var data = reader.ReadToEnd();

        JsonDocument jsonDocument = JsonDocument.Parse(data);
        JsonElement root = jsonDocument.RootElement;

        if (root.TryGetProperty("multiple", out JsonElement multipleProperty))
        {
            divisors.Add(multipleProperty.GetInt32());
            Console.WriteLine(multipleProperty.GetInt32());
        }

        if (root.TryGetProperty("word", out JsonElement wordProperty))
        {
            tokens.Add(wordProperty.GetString());
        }

        List<string> results = FizzBuzzCalculator.CalculateFizzBuzz(input, divisors, tokens);

        Console.WriteLine("FizzBuzz Results:");
        foreach (string result in results)
        {
            Console.WriteLine(result);
        }
    }
}