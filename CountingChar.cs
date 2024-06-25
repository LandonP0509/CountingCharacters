using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a string:");
        string input = Console.ReadLine();

        Dictionary<char, int> charCounts = new Dictionary<char, int>();

        foreach (char c in input)
        {

            char lowerChar = char.ToLower(c);

            if (char.IsLetter(lowerChar))
            {
        
                if (charCounts.ContainsKey(lowerChar))
                {
                    charCounts[lowerChar]++;
                }
                else
                {
                    charCounts[lowerChar] = 1;
                }
            }
        }

        foreach (KeyValuePair<char, int> entry in charCounts)
        {
            Console.WriteLine($"{entry.Key}:
        }
    }
}
