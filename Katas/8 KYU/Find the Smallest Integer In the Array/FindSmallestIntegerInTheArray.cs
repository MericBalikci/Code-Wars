/// <summary>
/// 
/// </summary>
public static class FindSmallestIntegerInTheArray
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    public static int FindSmallestInt(int[] args)
    {
        int temp = args[0];
        for (int i = 1; i < args.Length; i++)
        {
            if (args[i] < temp)
            {
                temp = args[i];
            }
        }
        return temp;
    }
}