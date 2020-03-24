/// <summary>
/// 
/// </summary>
public static class ROT13
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string Rot13(string input)
    {
        char[] result = new char[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            int ascii = input[i];
            if ((ascii >= 65 && ascii<=77) || (ascii >= 97 && ascii <= 109))
            {
                ascii += 13;
                result[i] = (char) ascii;
            }
            else if ((ascii >= 78 && ascii<=90) || (ascii >= 110 && ascii <= 122))
            {
                ascii -= 13;
                result[i] = (char) ascii;
            }
            else
            {
                result[i] = input[i];
            }
        }
        return new string(result);
    }
}