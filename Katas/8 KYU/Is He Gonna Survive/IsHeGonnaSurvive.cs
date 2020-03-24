/// <summary>
/// 
/// </summary>
public static class IsHeGonnaSurvive
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="bullets"></param>
    /// <param name="dragons"></param>
    /// <returns></returns>
    public static bool Hero(int bullets, int dragons)
    {
        return bullets >= (dragons * 2);
    }
}