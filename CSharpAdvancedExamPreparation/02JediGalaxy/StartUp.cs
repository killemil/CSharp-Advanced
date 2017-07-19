namespace _02JediGalaxy
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            int[] dimmensions = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = dimmensions[0];
            int cols = dimmensions[1];

            int[][] matrix = new int[rows][];

            FillMatrix(cols, matrix);

            string ivoInputCoordinates = Console.ReadLine();
            long ivoStartValue = 0;

            while (ivoInputCoordinates != "Let the Force be with you")
            {
                string evilInputCoordintes = Console.ReadLine();

                int[] ivoParsedCoordinates = ivoInputCoordinates.Split().Select(int.Parse).ToArray();
                int[] evilParsedCoordinates = evilInputCoordintes.Split().Select(int.Parse).ToArray();

                int currentIvoRow = ivoParsedCoordinates[0];
                int currentIvoCol = ivoParsedCoordinates[1];

                int currentEvilRow = evilParsedCoordinates[0];
                int currentEvilCol = evilParsedCoordinates[1];

                while (currentEvilRow >= 0 && currentEvilCol >= 0)
                {
                    if (IsInMatrix(matrix, currentEvilRow, currentEvilCol))
                    {
                        matrix[currentEvilRow][currentEvilCol] = 0;
                    }

                    currentEvilRow--;
                    currentEvilCol--;
                }

                while (currentIvoRow >= 0 && currentIvoCol < matrix.Length)
                {
                    if (IsInMatrix(matrix, currentIvoRow, currentIvoCol))
                    {
                        ivoStartValue += matrix[currentIvoRow][currentIvoCol];
                    }

                    currentIvoRow--;
                    currentIvoCol++;
                }

                ivoInputCoordinates = Console.ReadLine();
            }
            Console.WriteLine(ivoStartValue);
        }

        private static void FillMatrix(int cols, int[][] matrix)
        {
            int counter = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[cols];
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = counter++;
                }
            }
        }

        private static bool IsInMatrix(int[][] matrix, int givenRow, int givenCol)
        {
            bool result = givenRow >= 0
                && givenRow < matrix.Length
                && givenCol >= 0
                && givenCol < matrix[0].Length;

            return result;
        }
    }
}
