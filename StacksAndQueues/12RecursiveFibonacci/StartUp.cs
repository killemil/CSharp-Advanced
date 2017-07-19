namespace _12RecursiveFibonacci
{
    using System;

    public class StartUp
    {
        private static long[] fibNumbers;

        public static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            fibNumbers = new long[number];
            long result = GetFibunacci(number);

            Console.WriteLine(result);
        }

        private static long GetFibunacci(long number)
        {
            if (number <= 2)
            {
                return 1;
            }
            if (fibNumbers[number - 1] != 0)
            {
                return fibNumbers[number - 1];
            }
            return fibNumbers[number -1] = GetFibunacci(number - 1) + GetFibunacci(number - 2);
        }
    }
}
