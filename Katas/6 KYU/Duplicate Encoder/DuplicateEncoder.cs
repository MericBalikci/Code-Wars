using System;
using System.Collections.Generic;

/// <summary>
/// 
/// </summary>
public static class DuplicateEncoder
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="word"></param>
    /// <returns></returns>
    public static string DuplicateEncode(string word)
    {
        Dictionary<char,int> chars = new Dictionary<char, int>();
        List<int> changedIndexs = new List<int>();
        foreach (char character in word.ToLower())
        {
            if (chars.ContainsKey(character))
            {
                chars[character] += 1;
            }
            else
            {
                chars.Add(character,1);
            }
        }
        char[] result = word.ToLower().ToCharArray();
        foreach (char item in chars.Keys)
        {
            if (chars[item] >1)
            {
                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i].Equals(item) && !changedIndexs.Contains(i))
                    {
                        changedIndexs.Add(i);
                        result[i] = Convert.ToChar(")");
                    }
                }
            }
            else
            {
                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i].Equals(item) && !changedIndexs.Contains(i))
                    {
                        changedIndexs.Add(i);
                        result[i] = Convert.ToChar("(");
                    }
                }
            }
        }
        return new string(result);
    }
}