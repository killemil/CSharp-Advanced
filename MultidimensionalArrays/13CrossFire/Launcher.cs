namespace _13CrossFire
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Launcher
    {
        public static void Main()
        {
            int[] matrixSize = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int matrixRows = matrixSize[0];
            int matrixCols = matrixSize[1];
            List<List<int>> matrix = FillMatrix(matrixRows, matrixCols);

            string command = Console.ReadLine();

            while (!command.Equals("Nuke it from orbit"))
            {
                int[] commandTokens = command.Split()
                    .Select(int.Parse)
                    .ToArray();
                int shotRow = commandTokens[0];
                int shotCol = commandTokens[1];
                int shotRadius = commandTokens[2];

                for (int row = shotRow - shotRadius; row <= shotRow + shotRadius; row++)
                {
                    if (IsInMatrix(row, shotCol, matrix))
                    {
                        matrix[row][shotCol] = -1;
                    }
                }
                for (int col = shotCol - shotRadius; col <= shotCol + shotRadius; col++)
                {
                    if (IsInMatrix(shotRow, col, matrix))
                    {
                        matrix[shotRow][col] = -1;
                    }
                }

                FilterMatrix(matrix);

                command = Console.ReadLine();
            }

            Print(matrix);
        }

        private static void FilterMatrix(List<List<int>> matrix)
        {
            for (int row = matrix.Count - 1; row >= 0; row--)
            {
                for (int col = matrix[row].Count - 1; col >= 0; col--)
                {
                    if (matrix[row][col] == -1)
                    {
                        matrix[row].RemoveAt(col);
                    }
                }
                if (matrix[row].Count == 0)
                {
                    matrix.RemoveAt(row);
                }
            }
        }

        private static void Print(List<List<int>> matrix)
        {
            foreach (var line in matrix)
            {
                Console.WriteLine(string.Join(" ", line));
            }
        }

        private static bool IsInMatrix(int row, int shotCol, List<List<int>> matrix)
        {
            if (row >= 0 && row < matrix.Count &&
                shotCol >= 0 && shotCol < matrix[row].Count)
            {
                return true;
            }
            return false;
        }

        private static List<List<int>> FillMatrix(int matrixRows, int matrixCols)
        {
            List<List<int>> matrix = new List<List<int>>();
            int conter = 1;
            for (int i = 0; i < matrixRows; i++)
            {
                matrix.Add(new List<int>());
                for (int j = 0; j < matrixCols; j++)
                {
                    matrix[i].Add(conter);
                    conter++;
                }
            }
            return matrix;
        }
    }
}
