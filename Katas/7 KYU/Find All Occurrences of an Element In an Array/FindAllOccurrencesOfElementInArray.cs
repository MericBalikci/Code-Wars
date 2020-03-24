using System.Linq;

/// <summary>
/// 
/// </summary>
public class FindAllOccurrencesOfElementInArray
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="array"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public static int[] FindAll(int[] array, int n)
    {
        return array.Where(x => array[x] == n).ToArray();;
    }
}