namespace _02Nature_sProphet
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            int[][] matrix = new int[rows][];
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[cols];
            }

            string input = Console.ReadLine();

            while (input != "Bloom Bloom Plow")
            {
                int[] tokens = input.Split().Select(int.Parse).ToArray();
                int rowPosition = tokens[0];
                int colPosition = tokens[1];

                for (int row = 0; row < matrix.Length; row++)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        if (row == rowPosition)
                        {
                            matrix[row][col]++;

                        }
                        if (col == colPosition)
                        {
                            matrix[row][col]++;
                        }
                        if (row == rowPosition && col == colPosition)
                        {
                            matrix[row][col]--;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var line in matrix)
            {
                Console.WriteLine(string.Join(" ", line));
            }
        }
    }
}
