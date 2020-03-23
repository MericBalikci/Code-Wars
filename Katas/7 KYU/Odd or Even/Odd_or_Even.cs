using System.Linq;

/// <summary>
/// 
/// </summary>
public class Odd_or_Even
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public static string OddOrEven(int[] array)
    {
        return (array.Sum()%2 == 0) ? "even" : "odd";
    }
}