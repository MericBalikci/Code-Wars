using System.Text;

/// <summary>
/// 
/// </summary>
public static class GiveMeDiamond
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static string print(int n)
    {
        if (n < 0 || n % 2 == 0) return null;
        StringBuilder stringBuilder = new StringBuilder();
        int lineNumber = 1;
        while (lineNumber <= n)
        {
            if (lineNumber <= ((n - 1) / 2) + 1)
            {
                for (int i = 0; i < (n - ((lineNumber * 2) - 1))/2; i++)
                {
                    stringBuilder.Append(" ");
                }
                for (int i = 0; i < (lineNumber * 2) - 1; i++)
                {
                    stringBuilder.Append("*");
                }

                stringBuilder.Append("\n");
                lineNumber++;
            }
            else
            {
                for (int i = 0; i < (n - ((n - lineNumber) * 2 + 1))/2; i++)
                {
                    stringBuilder.Append(" ");
                }
                for (int i = 0; i < (n - lineNumber) * 2 + 1; i++)
                {
                    stringBuilder.Append("*");
                }

                stringBuilder.Append("\n");
                lineNumber++;
            }
        }

        return stringBuilder.ToString();
    }
}