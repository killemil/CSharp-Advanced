namespace _10TargetPractice
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] matrixSize = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string text = Console.ReadLine();
            int[] shotParams = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int shotRow = shotParams[0];
            int shotCol = shotParams[1];
            int shotRadius = shotParams[2];

            string[][] matrix = new string[matrixSize[0]][];
        }
    }
}
