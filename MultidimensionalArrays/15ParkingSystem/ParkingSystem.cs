namespace _15ParkingSystem
{
    using System;
    using System.Linq;

    public class ParkingSystem
    {
        public static void Main()
        {
            int[] parkingSize = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int parkingRows = parkingSize[0];
            int parkingCols = parkingSize[1];
            int[][] parking = new int[parkingRows][];
            for (int i = 0; i < parking.Length; i++)
            {
                parking[i] = new int[parkingCols];
            }

            string input = Console.ReadLine();
            while (!input.Equals("stop"))
            {
                int[] inputTokens = input
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int entryRow = inputTokens[0];
                int desiredRow = inputTokens[1];
                int desiredCol = inputTokens[2];

                if (parking[desiredRow][desiredCol] == 0)
                {
                    parking[desiredRow][desiredCol] = 1;
                    int moves = Math.Abs(entryRow - desiredRow) + 1 + desiredCol;
                    Console.WriteLine(moves);
                }
                else
                {
                    for (int col = 1; col < parking[0].Length; col++)
                    {
                        int prevPlace = desiredRow - col;
                        int nextPlace = desiredRow + col;
                        if (prevPlace >= 1 && parking[desiredRow][prevPlace] == 0)
                        {
                            parking[desiredRow][prevPlace] = 1;
                            int moves = Math.Abs(entryRow - desiredRow) + 1 + prevPlace;
                            Console.WriteLine(moves);
                            break;
                        }
                        else if (nextPlace <= parking[0].Length - 1 && parking[desiredRow][nextPlace] == 0)
                        {
                            parking[desiredRow][nextPlace] = 1;
                            int moves = Math.Abs(entryRow - desiredRow) + 1 + nextPlace;
                            Console.WriteLine(moves);
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Row {desiredRow} full");
                            break;
                        }
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
