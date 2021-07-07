using System;
using System.Collections.Generic;

namespace _8_Queens_Puzzle
{
    class EightQueens
    {
        private const int Size = 8;
        static int[,] chessboard = new int[Size, Size];
        static int solutionsFound = 0;

        static HashSet<int> attackedRows = new HashSet<int>();
        static HashSet<int> attackedCols = new HashSet<int>();

        static void Solve(int row)
        {
            if (row == Size)
            {
                PrintSolution();
                return;
            }
            else
            {
                for (int col = 0; col < Size; col++)
                {
                    if (CanPlaceQueen(row, col))
                    {
                        MarkAttackedFields(row, col);
                        Solve(row + 1);
                        UnmarkAttackedFields(row, col);
                    }
                }
            }
        }

        private static void PrintSolution()
        {
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    if (chessboard[row,col] == 1)
                    {
                        Console.Write("Q ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            solutionsFound++;
        }

        private static void UnmarkAttackedFields(int row, int col)
        {
            chessboard[row, col] = 0;
            attackedRows.Remove(row);
            attackedCols.Remove(col);
        }

        private static void MarkAttackedFields(int row, int col)
        {
            chessboard[row, col] = 1;
            attackedRows.Add(row);
            attackedCols.Add(col);
        }

        private static bool CanPlaceQueen(int row, int col)
        {
            if (attackedRows.Contains(row))
            {
                return false;
            }
            if (attackedCols.Contains(col))
            {
                return false;
            }

            // up left
            for (int i = 1; i < Size; i++)
            {
                int currentRow = row - i;
                int currentCol = col - i;

                if (!IsInside(currentRow, currentCol))
                {
                    break;
                }

                // queen here
                if (chessboard[currentRow, currentCol] == 1)
                {
                    return false;
                }
            }

            // up right
            for (int i = 1; i < Size; i++)
            {
                int currentRow = row - i;
                int currentCol = col + i;

                if (!IsInside(currentRow, currentCol))
                {
                    break;
                }

                // queen here
                if (chessboard[currentRow, currentCol] == 1)
                {
                    return false;
                }
            }

            // down left
            for (int i = 1; i < Size; i++)
            {
                int currentRow = row + i;
                int currentCol = col - i;

                if (!IsInside(currentRow, currentCol))
                {
                    break;
                }

                // queen here
                if (chessboard[currentRow, currentCol] == 1)
                {
                    return false;
                }
            }

            // down right
            for (int i = 1; i < Size; i++)
            {
                int currentRow = row + i;
                int currentCol = col + i;

                if (!IsInside(currentRow, currentCol))
                {
                    break;
                }

                // queen here
                if (chessboard[currentRow, currentCol] == 1)
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsInside(int row, int col)
        {
            return row >= 0 && row < chessboard.GetLength(0)
                && col >= 0 && col < chessboard.GetLength(1);
        }

        static void Main(string[] args)
        {
            Solve(0);
            Console.WriteLine($"Total solutions found: {solutionsFound}");
        }
    }
}
