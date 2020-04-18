using System.Linq;
using System.Text;
using System.Collections.Generic;

/// <summary>
/// 
/// </summary>
public static class WeightForWeight
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="strng"></param>
    /// <returns></returns>
    public static string orderWeight(string strng)
    {
        strng = strng.Trim();
        if (strng.Length == 0) return new string("");
        
        Dictionary<string,int> weights = new Dictionary<string, int>();
        Dictionary<string,int> sameWeights = new Dictionary<string, int>();
        
        foreach (string weight in strng.Split(" "))
        {
            if (weights.ContainsKey(weight))
            {
                if (sameWeights.ContainsKey(weight))
                {
                    sameWeights[weight] += 1;
                    continue;
                }
                sameWeights.Add(weight,1);
                continue;
            }
            weights.Add(weight,weight.Sum(c => c - '0'));
        }
        weights = new Dictionary<string, int>(weights.OrderBy(x => x.Value));
            
        List<int> values = weights.Values.Distinct().ToList();
        StringBuilder stringBuilder = new StringBuilder();
        foreach (int value in values)
        {
            foreach (KeyValuePair<string, int> pair in weights.Where(x => x.Value == value).OrderBy(x=>x.Key))
            {
                if (sameWeights.ContainsKey(pair.Key))
                {
                    for (int i = 0; i < sameWeights[pair.Key]; i++)
                    {
                        stringBuilder.Append(pair.Key + " ");
                    }
                }
                stringBuilder.Append(pair.Key + " ");
            }
        }
        return stringBuilder.Remove(stringBuilder.Length - 1, 1).ToString();
    }
}