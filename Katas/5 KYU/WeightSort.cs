using System;
using System.Linq;
using System.Collections.Generic;

/// <summary>
/// 
/// </summary>
public static class WeightSort
{
    public static string orderWeight(string str)
    {
        List<String> input = str.Split(" ").ToList();
        Dictionary<string,int> orderedNumbers = new Dictionary<string, int>();
        foreach (String number in input)
        {
            int sum = 0;
            foreach (char character in number)
            {
                sum += Int32.Parse(character.ToString());
            }
            orderedNumbers.Add(number,sum);
        }
        
        return String.Empty;
    }
}