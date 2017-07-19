namespace _12SortStudents
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
                .OrderBy(st => st[1])
                .ThenByDescending(st => st[0])
                .ToList()
                .ForEach(st => Console.WriteLine($"{st[0]} {st[1]}"));
        }
    }
}
