using System;
using System.Collections.Generic;

namespace _14FilterStudentsByPhone
{
    class StartUp
    {
        static void Main()
        {
            List<string[]> students = new List<string[]>();
            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] tokens = input.Split(' ');
                if (tokens[2].StartsWith("02") || tokens[2].StartsWith("+3592"))
                {
                    students.Add(input.Split(' '));
                }

                input = Console.ReadLine();
            }

            students
                .ForEach(st => Console.WriteLine($"{st[0]} {st[1]}"));
        }
    }
}
