using System.Collections.Generic;

/// <summary>
/// 
/// </summary>
public class MovingZerosToTheEnd
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public static int[] MoveZeroes(int[] arr)
    {
        int zeroCount = 0;
        List<int> result = new List<int>();
        foreach (int number in arr)
        {
            if (number == 0)
            {
                zeroCount++;
                continue;
            }
            result.Add(number);
        }
        for (int i = 0; i < zeroCount; i++)
        {
            result.Add(0);
        }
        return result.ToArray();
    }
}