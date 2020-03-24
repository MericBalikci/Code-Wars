using System.Linq;
using System.Collections.Generic;

/// <summary>
/// 
/// </summary>
public static class FindOddInt
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="seq"></param>
    /// <returns></returns>
    public static int find_it(int[] seq)
    {
         Dictionary<int,int> occurences = new Dictionary<int, int>();
         foreach (int number in seq)
         {
             if (occurences.ContainsKey(number)) occurences[number]++;
             else{occurences.Add(number,1);}
         }
         return occurences.Keys.First(x => occurences[x]%2==1);
    }
}