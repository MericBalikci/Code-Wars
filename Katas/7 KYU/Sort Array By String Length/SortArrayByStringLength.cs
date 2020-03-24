using System.Linq;

/// <summary>
/// 
/// </summary>
public static class SortArrayByStringLength
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public static string[] SortByLength (string[] array)
    {    
        return array.OrderBy(a => a.Length).ToArray();
    }
}