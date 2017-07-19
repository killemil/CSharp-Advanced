namespace _07BoundedNumbers
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            int[] boundNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            foreach (var num in numbers)
            {
                if (num <= boundNumbers.Max() && num >= boundNumbers.Min())
                {
                    Console.Write($"{num} ");
                }
            }
        }
    }
}
