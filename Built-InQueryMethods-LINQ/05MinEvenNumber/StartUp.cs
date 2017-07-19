namespace _05MinEvenNumber
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            var number = numbers.Where(n => n % 2 == 0).ToList();

            if (number.Any())
            {
                Console.WriteLine($"{number.Min():f2}");
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}
