using System;
using System.Linq;
using System.Collections.Generic;

/// <summary>
/// 
/// </summary>
public static class DetectPangram
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static bool IsPangram(string str)
    {
        List<char> input = str.ToLower().ToCharArray().ToList();
        var result = input.Where(x => x >= Convert.ToChar("a") && x <= Convert.ToChar("z"));
        return result.Distinct().ToList().Count == 26 ? true : false;
    }
}