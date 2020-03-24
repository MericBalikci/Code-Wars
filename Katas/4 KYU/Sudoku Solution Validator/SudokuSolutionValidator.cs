using System.Linq;
using System.Collections.Generic;

/// <summary>
/// 
/// </summary>
public static class SudokuSolutionValidator
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="board"></param>
    /// <returns></returns>
    public static bool ValidateSolution(int[][] board)
    {
        // Checks whether rows are valid or not.
        for (int row = 0; row < board.GetLength(0); row++)
        {
            List<int> rowElements = new List<int>();
            for (int column = 0; column < board.GetLength(0); column++)
            {
                rowElements.Add(board[row][column]);
            }
            if (rowElements.Contains(0) || (rowElements.Count != rowElements.Distinct().Count()))
            {
                return false;
            }
        }

        // Checks whether columns are valid or not.
        for (int column = 0; column < board.GetLength(0); column++)
        {
            List<int> columnElements = new List<int>();
            for (int row = 0; row < board.GetLength(0); row++)
            {
                columnElements.Add(board[row][column]);
            }
            if (columnElements.Contains(0) || columnElements.Count != columnElements.Distinct().Count())
            {
                return false;
            }
        }

        // Checks whether squares on board are valid or not.
        for (int squaredRow = 0; squaredRow < 3; squaredRow++)
        {
            for (int SquaredColumn = 0; SquaredColumn < 3; SquaredColumn++)
            {
                List<int> squareElements = new List<int>();
                for (int i = (squaredRow*3); i < (squaredRow*3)+3; i++)
                {
                    for (int j = (SquaredColumn*3); j < (SquaredColumn*3)+3; j++)
                    {
                        squareElements.Add(board[i][j]);
                    }
                }
                if (squareElements.Contains(0) || squareElements.Count != squareElements.Distinct().Count())
                {
                    return false;
                }
            }
        }
        
        return true;
    }
}