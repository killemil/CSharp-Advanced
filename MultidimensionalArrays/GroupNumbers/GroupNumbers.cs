namespace GroupNumbers
{
    using System;
    using System.Linq;

    public class GroupNumbers
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[][] matrix = new int[3][];

            int[] zeroExcess = numbers.Where(n => Math.Abs(n) % 3 == 0).ToArray();
            int[] oneExcess = numbers.Where(n => Math.Abs(n) % 3 == 1).ToArray();
            int[] twoExcess = numbers.Where(n => Math.Abs(n) % 3 == 2).ToArray();

            matrix[0] = zeroExcess;
            matrix[1] = oneExcess;
            matrix[2] = twoExcess;

            Console.WriteLine(string.Join(" ", matrix[0]));
            Console.WriteLine(string.Join(" ", matrix[1]));
            Console.WriteLine(string.Join(" ", matrix[2]));
        }
    }
}
