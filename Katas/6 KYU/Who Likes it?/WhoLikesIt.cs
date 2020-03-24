using System.Text;

/// <summary>
/// 
/// </summary>
public static class WhoLikesIt
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public static string Likes(string[] name)
    {
        StringBuilder stringBuilder = new StringBuilder();
        switch (name.Length)
        {
            case 0:
                return "no one likes this";
            case 1:
                return stringBuilder.AppendFormat("{0} likes this", name[0]).ToString();
            case 2:
                return stringBuilder.AppendFormat("{0} and {1} like this", name[0], name[1]).ToString();
            case 3:
                return stringBuilder.AppendFormat("{0}, {1} and {2} like this", name[0], name[1], name[2])
                    .ToString();
            default:
                return stringBuilder.AppendFormat("{0}, {1} and {2} others like this", name[0], name[1],
                    name.Length - 2).ToString();
        }
    }
}