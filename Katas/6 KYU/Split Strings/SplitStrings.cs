using System.Text;
using System.Collections.Generic;

/// <summary>
/// 
/// </summary>
public static class SplitStrings
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static string[] Solution(string str)
    {
        List<string> result = new List<string>();
        if (str.Length % 2 == 0)
        {
            for (int i = 0; i < str.Length - 1; i += 2)
            {
                result.Add(str.Substring(i, 2));
            }
        }
        else
        {
            for (int i = 0; i < str.Length; i += 2)
            {
                if (i + 1 > str.Length - 1)
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.Append(str.Substring(i, 1));
                    stringBuilder.Append("_");
                    result.Add(stringBuilder.ToString());
                }
                else
                {
                    result.Add(str.Substring(i, 2));
                }
            }
        }
        return result.ToArray();
    }
}