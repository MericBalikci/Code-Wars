using System;
using System.Linq;
using System.Collections.Generic;

public static class Anagram_Detection
{
    public static bool IsAnagram(string test, string original)
    {
        return string.Concat(test.ToLower().OrderBy(a => a)).Equals(string.Concat(original.ToLower().OrderBy(a => a)));
    }
}