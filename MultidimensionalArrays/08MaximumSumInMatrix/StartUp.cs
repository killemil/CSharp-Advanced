
namespace _08MaximumSumInMatrix
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] matrixSize = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[][] matrix = new int[matrixSize[0]][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            long sum = long.MinValue;
            int startRowIndex = 0;
            int startColIndex = 0;

            for (int row = 0; row < matrix.Length - 2; row++)
            {
                long currentSum = 0;
                for (int col = 0; col < matrix[row].Length - 2; col++)
                {
                    currentSum = matrix[row][col] +
                                 matrix[row][col + 1] +
                                 matrix[row][col + 2] +
                                 matrix[row + 1][col] +
                                 matrix[row + 1][col + 1] +
                                 matrix[row + 1][col + 2] +
                                 matrix[row + 2][col] +
                                 matrix[row + 2][col + 1] +
                                 matrix[row + 2][col + 2];
                    if (currentSum > sum)
                    {
                        sum = currentSum;
                        startRowIndex = row;
                        startColIndex = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {sum}");
            for (int row = startRowIndex; row < startRowIndex + 3; row++)
            {
                for (int col = startColIndex; col < startColIndex + 3; col++)
                {
                    Console.Write($"{matrix[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
