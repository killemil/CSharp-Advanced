namespace _06FindAndSumIntegers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            List<string> text = Console.ReadLine()
                .Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<long> numbers = new List<long>();
            foreach (var item in text)
            {
                int num;
                bool isInteger = int.TryParse(item, out num);
                if (isInteger)
                {
                    numbers.Add(num);
                }
            }

            if (numbers.Any())
            {
                Console.WriteLine(numbers.Sum());
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}
