using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

/// <summary>
/// 
/// </summary>
public static class WeirdStringCase
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static string ToWeirdCase(string s)
    {
        Dictionary<int, char[]> str = new Dictionary<int, char[]>();
        int stringCount = 0;
        foreach (String a in s.Split().ToArray())
        {
            str.Add(stringCount, a.ToCharArray());
            stringCount++;
        }

        foreach (char[] value in str.Values)
        {
            int letterNumber = 0;
            for (int i = 0; i < value.Length; i++)
            {
                if (String.IsNullOrWhiteSpace(value[i].ToString()))
                {
                    continue;
                }

                if (letterNumber % 2 == 0)
                {
                    value[i] = Convert.ToChar(value[i].ToString().ToUpper());
                    letterNumber++;
                }
                else
                {
                    value[i] = Convert.ToChar(value[i].ToString().ToLower());
                    letterNumber++;
                }
            }
        }

        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < str.Keys.Count; i++)
        {
            if (str.Keys.Count == i + 1)
            {
                stringBuilder.Append(new string(str[i]));
            }
            else
            {
                stringBuilder.Append(new string(str[i]) + " ");
            }
        }

        return stringBuilder.ToString();
    }
}