using System;
using System.Linq;

public class Odd_or_Even
{
    public static string OddOrEven(int[] array)
    {
        return (array.Sum()%2 == 0) ? "even" : "odd";
    }
}