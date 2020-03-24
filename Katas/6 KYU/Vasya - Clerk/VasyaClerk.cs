using System.Collections.Generic;

/// <summary>
/// 
/// </summary>
public static class VasyaClerk
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="peopleInLine"></param>
    /// <returns></returns>
    public static string Tickets(int[] peopleInLine)
    {
        Dictionary<int,int> cashRegister = new Dictionary<int, int>()
        {
            {25,0},{50,0},{100,0}
        };
        foreach (int money in peopleInLine)
        {
            if (money == 25)
            {
                cashRegister[25] += 1;
            }
            else if (money == 50)
            {
                if (cashRegister[25] == 0)
                {
                    return "NO";
                }
                else
                {
                    cashRegister[25] -= 1;
                    cashRegister[50] += 1;
                }
            }
            else
            {
                if (cashRegister[50] == 0)
                {
                    if (cashRegister[25] < 3)
                    {
                        return "NO";
                    }
                    else
                    {
                        cashRegister[25] -= 3;
                        cashRegister[100] += 1;
                    }
                }
                else
                {
                    if (cashRegister[25] == 0)
                    {
                        return "NO";
                    }
                    else
                    {
                        cashRegister[25] -= 1;
                        cashRegister[50] -= 1;
                        cashRegister[100] += 1;
                    }
                }
            }
        }
        return "YES";
    }
}