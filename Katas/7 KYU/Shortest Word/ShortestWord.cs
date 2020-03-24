using System.Linq;
using System.Collections.Generic;

/// <summary>
/// 
/// </summary>
public static class ShortestWord
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static int FindShort(string s)
    {
        List<string> words = s.Split(" ").ToList();
        return words.Min(a => a.Length);
    }
}