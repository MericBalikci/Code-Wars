using System.Linq;
using System.Collections.Generic;

/// <summary>
/// 
/// </summary>
public static class TribonacciSequence
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="signature"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public static double[] Tribonacci(double[] signature, int n)
    {
        List<double> temp = signature.ToList();
        if (n < 4)
        {
            List<double> less = new List<double>();
            for (int i = 0; i < n; i++)
            {
                less.Add(signature[i]);
            }

            return less.ToArray();
        }

        while (temp.Count < n)
        {
            double newNumber = 0;
            for (int i = 0; i < 3; i++)
            {
                newNumber += temp[(temp.Count - 1) - i];
            }

            temp.Add(newNumber);
        }

        return temp.ToArray();
    }
}