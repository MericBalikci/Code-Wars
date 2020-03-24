using System;

/// <summary>
/// 
/// </summary>
public static class HumanReadableTime
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="seconds"></param>
    /// <returns></returns>
    public static string GetReadableTime(int seconds)
    {
        TimeSpan timeSpan = TimeSpan.FromSeconds( seconds );
        return string.Format("{0:D2}:{1:D2}:{2:D2}", (timeSpan.Days*24)+timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
    }
}