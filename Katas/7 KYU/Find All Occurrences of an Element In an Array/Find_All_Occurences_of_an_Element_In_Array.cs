using System;
using System.Linq;
using System.Collections.Generic;

public class Find_All_Occurences_of_an_Element_In_Array
{
    public static int[] FindAll(int[] array, int n)
    {
        List<int> list = array.ToList();
        return Enumerable.Range(0,list.Count).Where(i => list[i] == n).ToArray();
    }
}