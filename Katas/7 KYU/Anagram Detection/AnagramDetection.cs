using System.Linq;

/// <summary>
/// 
/// </summary>
public static class AnagramDetection
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="test"></param>
    /// <param name="original"></param>
    /// <returns></returns>
    public static bool IsAnagram(string test, string original)
    {
        return test.ToLower().OrderBy(a => a).Equals(original.ToLower().OrderBy(a => a));
    }
}