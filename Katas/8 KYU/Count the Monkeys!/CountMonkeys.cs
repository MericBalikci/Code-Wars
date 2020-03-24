/// <summary>
/// 
/// </summary>
public static class CountMonkeys
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static int[] MonkeyCount(int n)
    {
        int[] numbers = new int[n];
        for(int i = 1; i<=n; i++)
        {
            numbers[i-1] = i;  
        }
        return numbers;
    }
}