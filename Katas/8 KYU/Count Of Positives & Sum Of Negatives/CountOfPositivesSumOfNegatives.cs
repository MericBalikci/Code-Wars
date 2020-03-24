/// <summary>
/// 
/// </summary>
public static class CountOfPositivesSumOfNegatives
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static int[] CountPositivesSumNegatives(int[] input)
    {
        if(input == null) return new int[0];
        if(input.Length>0 )
        {
            int countPositives = 0;
            int sumNegatives = 0;
            for(int i = 0; i<input.Length; i++)
            {
                if(input[i]<0)
                {
                    sumNegatives += input[i];
                }  
                else if(input[i]>0)
                {
                    countPositives++;
                }
            }
            return new int[] {countPositives, sumNegatives};
        } 
        return new int[0];
    }
}