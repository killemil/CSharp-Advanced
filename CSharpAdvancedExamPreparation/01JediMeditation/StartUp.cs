
namespace _01JediMeditation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());

            List<string> knights = new List<string>();
            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in input)
                {
                    knights.Add(item);
                }
            }

            List<string> result = new List<string>();
            if (knights.Any(x => x.StartsWith("y")))
            {
                result.AddRange(knights.Where(x => x.StartsWith("m")));
                result.AddRange(knights.Where(x => x.StartsWith("k")));
                result.AddRange(knights.Where(x => x.StartsWith("t") || x.StartsWith("s")));
                result.AddRange(knights.Where(x => x.StartsWith("p")));
            }
            else
            {
                result.AddRange(knights.Where(x => x.StartsWith("t") || x.StartsWith("s")));
                result.AddRange(knights.Where(x => x.StartsWith("m")));
                result.AddRange(knights.Where(x => x.StartsWith("k")));
                result.AddRange(knights.Where(x => x.StartsWith("p")));
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
