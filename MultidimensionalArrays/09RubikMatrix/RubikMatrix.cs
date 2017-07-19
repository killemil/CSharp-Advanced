namespace _09RubikMatrix
{
    using System;
    using System.Linq;

    public class RubikMatrix
    {
        public static void Main()
        {
            int[] matrixSize = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = matrixSize[0];
            int cols = matrixSize[1];
            int numbersOfcommands = int.Parse(Console.ReadLine());
            int[][] matrix = new int[matrixSize[0]][];
            int filler = 1;

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new int[matrixSize[1]];
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = filler;
                    filler++;
                }
            }

            for (int i = 0; i < numbersOfcommands; i++)
            {
                string[] commands = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int rowOrCol = int.Parse(commands[0]);
                string direction = commands[1];
                int moves = int.Parse(commands[2]);

                switch (direction)
                {
                    case "up":
                        MoveCol(matrix, rowOrCol, moves);
                        break;
                    case "down":
                        MoveCol(matrix, rowOrCol, rows - moves % rows);
                        break;
                    case "left":
                        MoveRow(matrix, rowOrCol, moves);
                        break;
                    case "right":
                        MoveRow(matrix, rowOrCol, cols - moves % cols);
                        break;
                }
            }

            var element = 1;
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == element)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
                        {
                            for (int colIndex = 0; colIndex < matrix[rowIndex].Length; colIndex++)
                            {
                                if (matrix[rowIndex][colIndex] == element)
                                {
                                    int currentElement = matrix[row][col];
                                    matrix[row][col] = element;
                                    matrix[rowIndex][colIndex] = currentElement;

                                    Console.WriteLine($"Swap ({row}, {col}) with ({rowIndex}, {colIndex})");
                                    break;
                                }
                            }
                        }
                    }
                    element++;
                }
            }
        }

        private static void MoveRow(int[][] matrix, int rowOrCol, int moves)
        {
            int[] temp = new int[matrix[0].Length];
            for (int col = 0; col < matrix[0].Length; col++)
            {
                temp[col] = matrix[rowOrCol][(col + moves) % matrix[0].Length];
            }

            matrix[rowOrCol] = temp;
        }

        private static void MoveCol(int[][] matrix, int rowOrCol, int moves)
        {
            int[] temp = new int[matrix.Length];
            for (int row = 0; row < matrix.Length; row++)
            {
                temp[row] = matrix[(row + moves) % matrix.Length][rowOrCol];
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row][rowOrCol] = temp[row];
            }
        }
    }
}
