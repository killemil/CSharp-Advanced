namespace _04AverageOfDoubles
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Console.WriteLine($"{numbers.Average():f2}");
        }
    }
}
