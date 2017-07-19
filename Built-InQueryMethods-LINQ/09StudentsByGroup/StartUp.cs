namespace _09StudentsByGroup
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
                .Where(gr => gr[2] == "2")
                .OrderBy(st => st[0])
                .ToList()
                .ForEach(st => Console.WriteLine($"{st[0]} {st[1]}"));
        }
    }
}
