using System.Collections.Generic;

/// <summary>
/// 
/// </summary>
public static class PickPeaks
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public static Dictionary<string, List<int>> GetPeaks(int[] arr)
    {
        Dictionary<string,List<int>> result = new Dictionary<string, List<int>>()
        {
            {"pos",new List<int>()}, {"peaks",new List<int>()}
        };
        if (arr.Length<=2) return result;
        for (int i = 1; i < arr.Length-1; i++)
        {
            if (arr[i]>arr[i-1] && arr[i] > arr[i+1])
            {
                result["pos"].Add(i);
                result["peaks"].Add(arr[i]);
            }
            else if (arr[i]>arr[i-1] && arr[i] == arr[i+1])
            {
                int plateuIndex = i;
                while (plateuIndex < arr.Length-2 && arr[plateuIndex] == arr[plateuIndex+1])
                {
                    plateuIndex++;
                }
                if (plateuIndex == arr.Length)
                {
                    continue;
                }
                if (arr[plateuIndex]>arr[plateuIndex+1])
                {
                    result["pos"].Add(i);
                    result["peaks"].Add(arr[i]);
                }
            }
        }
        return result;
    }
}