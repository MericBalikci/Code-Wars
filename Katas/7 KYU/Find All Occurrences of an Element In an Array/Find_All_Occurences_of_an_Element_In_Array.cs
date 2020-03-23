using System.Linq;

/// <summary>
/// 
/// </summary>
public class Find_All_Occurences_of_an_Element_In_Array
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