namespace _02MaximumSumOf2x2submatrix
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] matrixSize = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[][] matrix = new int[matrixSize[0]][];

            int startRow = 0;
            int startCol = 0;
            int sum = int.MinValue;

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            for (int row = 0; row < matrix.Length - 1; row++)
            {
                int currentSum = 0;
                for (int col = 0; col < matrix[row].Length - 1; col++)
                {
                    currentSum = matrix[row][col] +
                                 matrix[row][col + 1] +
                                 matrix[row + 1][col] +
                                 matrix[row + 1][col + 1];
                    if (currentSum > sum)
                    {
                        sum = currentSum;
                        startRow = row;
                        startCol = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[startRow][startCol]} {matrix[startRow][startCol + 1]}\r\n{matrix[startRow + 1][startCol]} {matrix[startRow + 1][startCol + 1]}\r\n{sum}");
        }
    }
}
