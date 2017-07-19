namespace _06DiagonalDifference
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[][] matrix = new int[matrixSize][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            long leftDiagonalSum = 0;
            long rightDiagonalSum = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                leftDiagonalSum += matrix[i][i];
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                rightDiagonalSum += matrix[matrix.Length - 1 - i][i];
            }

            Console.WriteLine(Math.Abs(leftDiagonalSum - rightDiagonalSum));
        }
    }
}
