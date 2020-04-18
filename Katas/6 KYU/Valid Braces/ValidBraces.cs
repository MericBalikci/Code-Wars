using System;
using System.Linq;
using System.Collections.Generic;

/// <summary>
/// 
/// </summary>
public static class ValidBraces
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="braces"></param>
    /// <returns></returns>
    public static bool validBraces(String braces)
    {
        List<char> braceList = new List<char>();
        foreach (char brace in braces)
        {
            if (brace.ToString().Equals("(") || brace.ToString().Equals("[") || brace.ToString().Equals("{"))
            {
                braceList.Add(brace);
            }
            else if (brace.ToString().Equals(")") || brace.ToString().Equals("]") || brace.ToString().Equals("}"))
            {
                if (braceList.Count == 0) return false;
                switch (brace.ToString())
                {
                    case ")":
                        if (braceList[braceList.Count-1].ToString().Equals("(")) 
                        {
                            braceList.RemoveAt(braceList.Count-1);
                            continue;
                        }
                        return false;
                    case "]":
                        if (braceList[braceList.Count-1].ToString().Equals("[")) 
                        {
                            braceList.RemoveAt(braceList.Count-1);
                            continue;
                        }
                        return false;
                    case "}":
                        if (braceList[braceList.Count-1].ToString().Equals("{")) 
                        {
                            braceList.RemoveAt(braceList.Count-1);
                            continue;
                        }
                        return false;
                }
            }
        }
        return braceList.Count == 0;
    }
}