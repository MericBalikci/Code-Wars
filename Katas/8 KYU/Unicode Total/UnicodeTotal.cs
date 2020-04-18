/// <summary>
/// 
/// </summary>
public static class UnicodeTotal
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static int UniTotal(string str)
    {
        if (str.Length == 0) return 0;
        int total = 0;
        foreach (char c in str)
        {
            total += c;
        }
        return total;
    }
}