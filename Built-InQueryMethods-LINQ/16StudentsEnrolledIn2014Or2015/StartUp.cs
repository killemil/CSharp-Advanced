namespace _16StudentsEnrolledIn2014Or2015
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
                .Where(st => st[0].EndsWith("14") || st[0].EndsWith("15"))
                .ToList()
                .ForEach(st => Console.WriteLine(string.Join(" ", st.Skip(1))));
        }
    }
}
