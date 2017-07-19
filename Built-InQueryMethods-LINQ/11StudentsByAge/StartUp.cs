namespace _11StudentsByAge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            List<string[]> students = new List<string[]>();
            string input = Console.ReadLine();

            while (input != "END")
            {
                students.Add(input.Split(' '));

                input = Console.ReadLine();
            }
            students
                .Where(st => int.Parse(st[2]) >= 18 && int.Parse(st[2]) <= 24)
                .ToList()
                .ForEach(st => Console.WriteLine($"{st[0]} {st[1]} {st[2]}"));
        }
    }
}
