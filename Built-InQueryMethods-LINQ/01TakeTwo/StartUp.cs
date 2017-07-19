namespace _01TakeTwo
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var result = numbers.Where(n => n >= 10 && n <= 20).Distinct().Take(2).ToArray();

            if (result.Any())
            {
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
