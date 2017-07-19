namespace _15ExcellentStudents
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
                .Where(st => st.Skip(2).Count(mark => int.Parse(mark) <= 3) >= 2)
                .ToList()
                .ForEach(st => Console.WriteLine($"{st[0]} {st[1]}"));
        }
    }
}
