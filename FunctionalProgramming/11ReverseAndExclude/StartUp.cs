namespace _11ReverseAndExclude
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int devider = int.Parse(Console.ReadLine());

            Array.Reverse(numbers);
            Console.WriteLine(string.Join(" ", numbers.Where(n => n % devider != 0)));
        }
    }
}
