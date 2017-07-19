
namespace _11LegoBlocks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] firstMatrix = new int[rows][];
            int[][] secondMatrix = new int[rows][];

            for (int i = 0; i < rows * 2; i++)
            {
                if (i < rows)
                {
                    firstMatrix[i] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                }
                else
                {
                    secondMatrix[i - rows] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                }
            }

            for (int row = 0; row < secondMatrix.Length; row++)
            {
                List<int> currentRow = secondMatrix[row].ToList();
                currentRow.Reverse();
                secondMatrix[row] = currentRow.ToArray();
            }

            bool hasEqualSize = false;
            for (int row = 0; row < rows - 1; row++)
            {
                if (firstMatrix[row].Length + secondMatrix[row].Length ==
                    firstMatrix[row + 1].Length + secondMatrix[row + 1].Length)
                {
                    hasEqualSize = true;
                }
                else
                {
                    hasEqualSize = false;
                    break;
                }
            }

            if (hasEqualSize)
            {
                int cols = firstMatrix[0].Length + secondMatrix[0].Length;
                int[][] unitedMatrix = new int[rows][];
                for (int row = 0; row < unitedMatrix.Length; row++)
                {
                    unitedMatrix[row] = new int[cols];
                    Array.Copy(firstMatrix[row], unitedMatrix[row], firstMatrix[row].Length);
                    Array.Copy(secondMatrix[row], 0, unitedMatrix[row], firstMatrix[row].Length, secondMatrix[row].Length);
                }
                foreach (var row in unitedMatrix)
                {
                    Console.WriteLine($"[{string.Join(", ", row)}]");
                }
            }
            else
            {
                int counter = 0;
                for (int row = 0; row < firstMatrix.Length; row++)
                {
                    counter += firstMatrix[row].Length;
                }
                for (int row = 0; row < secondMatrix.Length; row++)
                {
                    counter += secondMatrix[row].Length;
                }
                Console.WriteLine($"The total number of cells is: {counter}");
            }
        }
    }
}
