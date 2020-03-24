using System.Collections.Generic;

/// <summary>
/// 
/// </summary>
public static class SnailSort
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public static int[] Snail(int[][] array)
    {
        if (array[0].Length == 0) return new int[0];
        List<int> result = new List<int>();
        int iterator, rowIndex = 0, columnIndex = 0;
        int endingRowIndex, endingColumnIndex;
        endingRowIndex = endingColumnIndex = array.Length;

        while (rowIndex < endingRowIndex && columnIndex < endingColumnIndex)
        {
            for (iterator = columnIndex; iterator < endingColumnIndex; ++iterator)
            {
                result.Add(array[rowIndex][iterator]);
            }

            rowIndex++;

            for (iterator = rowIndex; iterator < endingRowIndex; ++iterator)
            {
                result.Add(array[iterator][endingColumnIndex - 1]);
            }

            endingColumnIndex--;

            if (rowIndex < endingRowIndex)
            {
                for (iterator = endingColumnIndex - 1; iterator >= columnIndex; --iterator)
                {
                    result.Add(array[endingRowIndex - 1][iterator]);
                }

                endingRowIndex--;
            }

            if (columnIndex < endingColumnIndex)
            {
                for (iterator = endingRowIndex - 1; iterator >= rowIndex; --iterator)
                {
                    result.Add(array[iterator][columnIndex]);
                }

                columnIndex++;
            }
        }

        return result.ToArray();
    }
}