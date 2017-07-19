namespace _12VampireBunnies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] matrixSize = Console.ReadLine().
                Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rowSize = matrixSize[0];
            int colSize = matrixSize[1];

            char[][] matrix = new char[rowSize][];

            for (int row = 0; row < matrix.Length; row++)
            {
                string input = Console.ReadLine();
                matrix[row] = input.ToCharArray();
            }

            string commands = Console.ReadLine();
            bool isGameEnd = false;
            bool isWin = false;
            foreach (var c in commands)
            {
                int endRow = 0;
                int endCol = 0;
                bool isFound = false;
                if (c.Equals('R'))
                {
                    for (int row = 0; row < matrix.Length; row++)
                    {
                        if (isFound)
                        {
                            break;
                        }
                        for (int col = 0; col < matrix[row].Length; col++)
                        {
                            if (matrix[row][col] == 'P')
                            {
                                int endGame = col + 1;
                                if (endGame > matrix[row].Length - 1)
                                {
                                    isGameEnd = true;
                                    isWin = true;
                                    endRow = row;
                                    endCol = col;
                                    matrix[row][col] = '.';
                                    break;
                                }
                                matrix[row][col] = '.';
                                if (matrix[row][col + 1] == 'B')
                                {
                                    isGameEnd = true;
                                    endRow = row;
                                    endCol = col + 1;
                                }
                                matrix[row][col + 1] = 'P';
                                isFound = true;
                                break;
                            }
                        }
                    }
                }
                else if (c.Equals('L'))
                {
                    for (int row = 0; row < matrix.Length; row++)
                    {
                        if (isFound)
                        {
                            break;
                        }
                        for (int col = 0; col < matrix[row].Length; col++)
                        {
                            if (matrix[row][col] == 'P')
                            {
                                int endGame = col - 1;
                                if (endGame < 0)
                                {
                                    isGameEnd = true;
                                    isWin = true;
                                    endRow = row;
                                    endCol = col;
                                    matrix[row][col] = '.';
                                    break;
                                }
                                matrix[row][col] = '.';
                                if (matrix[row][col - 1] == 'B')
                                {
                                    isGameEnd = true;
                                    endRow = row;
                                    endCol = col - 1;
                                }
                                matrix[row][col - 1] = 'P';
                                isFound = true;
                                break;
                            }
                        }
                    }
                }
                else if (c.Equals('U'))
                {
                    for (int row = 0; row < matrix.Length; row++)
                    {
                        if (isFound)
                        {
                            break;
                        }
                        for (int col = 0; col < matrix[row].Length; col++)
                        {
                            if (matrix[row][col] == 'P')
                            {
                                int endGame = row - 1;
                                if (endGame < 0)
                                {
                                    isGameEnd = true;
                                    isWin = true;
                                    endRow = row;
                                    endCol = col;
                                    matrix[row][col] = '.';
                                    break;
                                }
                                matrix[row][col] = '.';
                                if (matrix[row - 1][col] == 'B')
                                {
                                    isGameEnd = true;
                                    endRow = row - 1;
                                    endCol = col;
                                }
                                matrix[row - 1][col] = 'P';
                                isFound = true;
                                break;
                            }
                        }
                    }
                }
                else if (c.Equals('D'))
                {
                    for (int row = 0; row < matrix.Length; row++)
                    {
                        if (isFound)
                        {
                            break;
                        }
                        for (int col = 0; col < matrix[row].Length; col++)
                        {
                            if (matrix[row][col] == 'P')
                            {
                                int endGame = row + 1;
                                if (endGame > matrix.Length - 1)
                                {
                                    isGameEnd = true;
                                    isWin = true;
                                    endRow = row;
                                    endCol = col;
                                    matrix[row][col] = '.';
                                    break;
                                }
                                matrix[row][col] = '.';
                                if (matrix[row + 1][col] == 'B')
                                {
                                    isGameEnd = true;
                                    endRow = row + 1;
                                    endCol = col;
                                }
                                matrix[row + 1][col] = 'P';
                                isFound = true;
                                break;
                            }
                        }
                    }
                }
                Dictionary<int, List<int>> bunnies = new Dictionary<int, List<int>>();
                for (int row = 0; row < matrix.Length; row++)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        if (matrix[row][col] == 'B')
                        {
                            if (!bunnies.ContainsKey(row))
                            {
                                bunnies[row] = new List<int>();
                            }
                            bunnies[row].Add(col);
                        }
                    }
                }
                foreach (var bunny in bunnies)
                {
                    int row = bunny.Key;
                    foreach (var bunnyCol in bunny.Value)
                    {
                        int col = bunnyCol;
                        int matrixUp = row - 1;
                        int matrixDown = row + 1;
                        int matrixLeft = col - 1;
                        int matrixRight = col + 1;
                        if (matrixUp >= 0)
                        {
                            matrix[row - 1][col] = 'B';
                            if (matrix[row - 1][col] == 'P')
                            {
                                isGameEnd = true;
                                endRow = row - 1;
                                endCol = col;
                            }
                        }
                        if (matrixDown <= matrix.Length - 1)
                        {
                            matrix[row + 1][col] = 'B';
                            if (matrix[row + 1][col] == 'P')
                            {
                                isGameEnd = true;
                                endRow = row + 1;
                                endCol = col;
                            }
                        }
                        if (matrixLeft >= 0)
                        {
                            matrix[row][col - 1] = 'B';
                            if (matrix[row][col - 1] == 'P')
                            {
                                isGameEnd = true;
                                endRow = row;
                                endCol = col - 1;
                            }
                        }
                        if (matrixRight <= matrix[row].Length - 1)
                        {
                            matrix[row][col + 1] = 'B';
                            if (matrix[row][col + 1] == 'P')
                            {
                                isGameEnd = true;
                                endRow = row;
                                endCol = col + 1;
                            }
                        }
                    }

                }
                if (isGameEnd == true)
                {
                    if (isWin)
                    {
                        foreach (var line in matrix)
                        {
                            Console.WriteLine(string.Join("", line));
                        }

                        Console.WriteLine($"won: {endRow} {endCol}");
                    }
                    else
                    {
                        foreach (var line in matrix)
                        {
                            Console.WriteLine(string.Join("", line));
                        }

                        Console.WriteLine($"dead: {endRow} {endCol}");
                    }
                    return;
                }
            }
        }
    }
}
