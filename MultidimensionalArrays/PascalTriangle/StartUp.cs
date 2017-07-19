namespace PascalTriangle
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int numberOfRows = int.Parse(Console.ReadLine());

            long[][] triangle = new long[numberOfRows][];

            for (int row = 0; row < numberOfRows; row++)
            {
                triangle[row] = new long[row + 1];
                triangle[row][0] = 1;
                triangle[row][triangle[row].Length - 1] = 1;

                for (int col = 1; col < triangle[row].Length - 1; col++)
                {
                    triangle[row][col] = triangle[row - 1][col - 1] + triangle[row - 1][col];
                }
            }

            foreach (var row in triangle)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
