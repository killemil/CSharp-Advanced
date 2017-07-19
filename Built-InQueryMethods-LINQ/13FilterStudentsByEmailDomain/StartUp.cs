using System;
using System.Collections.Generic;
using System.Linq;

namespace _13FilterStudentsByEmailDomain
{
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
                .Where(st => st[2].EndsWith("@gmail.com"))
                .ToList()
                .ForEach(st => Console.WriteLine($"{st[0]} {st[1]}"));
        }
    }
}
