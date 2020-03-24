using System.Linq;

/// <summary>
/// 
/// </summary>
public static class OddOrEven
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public static string oddOrEven(int[] array)
    {
        return (array.Sum()%2 == 0) ? "even" : "odd";
    }
}