using System.Linq;
using System.Collections.Generic;

/// <summary>
/// 
/// </summary>
public static class Scramblies
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="str1"></param>
    /// <param name="str2"></param>
    /// <returns></returns>
    public static bool Scramble(string str1, string str2)
    {
        Dictionary<char,int> string1 = new Dictionary<char, int>();
        Dictionary<char,int> string2 = new Dictionary<char, int>();
        foreach (var VARIABLE in str1)
        {
            if (string1.ContainsKey(VARIABLE))
            {
                string1[VARIABLE]++;
            }
            else
            {
                string1.Add(VARIABLE,1);
            }
        }
        
        foreach (var VARIABLE in str2)
        {
            if (string2.ContainsKey(VARIABLE))
            {
                string2[VARIABLE]++;
            }
            else
            {
                string2.Add(VARIABLE,1);
            }
        }
        
        int sameAmount = 0;
        foreach (var VARIABLE in string2.Keys)
        {
            if (string1.ContainsKey(VARIABLE) && string1[VARIABLE] >= string2[VARIABLE])
            {
                sameAmount++;
            }
        }

        if (sameAmount == str2.Distinct().ToList().Count)
        {
            return true;
        }

        return false;
    }
}