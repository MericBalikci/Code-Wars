using System;

/// <summary>
/// 
/// </summary>
public static class RemoveFirstAndLastCharacter
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static string Remove_char(string s)
    {
        if (s.Length <= 2) return String.Empty;
        s = s.Remove(s.Length-1, 1);
        s = s.Remove(0, 1);
        return s;
    }
}