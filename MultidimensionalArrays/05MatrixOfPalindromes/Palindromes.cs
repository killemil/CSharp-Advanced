namespace _05MatrixOfPalindromes
{
    using System;
    using System.Linq;

    public class Palindromes
    {
        public static void Main()
        {
            int[] matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            int matrixRows = matrixSize[0];
            int matrixCols = matrixSize[1];

            string[][] matrix = new string[matrixRows][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new string[matrixCols];
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = alphabet[row].ToString() +
                                       alphabet[col + row].ToString() +
                                       alphabet[row].ToString();
                }
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
