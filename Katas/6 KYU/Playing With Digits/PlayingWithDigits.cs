using System;

/// <summary>
/// 
/// </summary>
public static class PlayingWithDigits
{
   /// <summary>
   /// 
   /// </summary>
   /// <param name="n"></param>
   /// <param name="p"></param>
   /// <returns></returns>
   public static long digPow(int n, int p) {
      int total = 0;
      foreach (char number in n.ToString())
      {
         total += (int) MathF.Pow(Int32.Parse(number.ToString()), p);
         p++;
      }
      if (total % n == 0)
      {
         return total / n;
      }
      return -1;
   }
}