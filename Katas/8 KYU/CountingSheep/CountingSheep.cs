/// <summary>
/// 
/// </summary>
public static class CountingSheep
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sheeps"></param>
    /// <returns></returns>
    public static int CountSheeps(bool[] sheeps)
    {
        int sheepCount = 0;
        if(sheeps != null && sheeps.Length>0)
        {
            for (int i =0; i<sheeps.Length; i++)
            {
                if(sheeps[i] == true){
                    sheepCount++;
                }
            }
            return sheepCount;
        } 
        return 0;  
    }
}