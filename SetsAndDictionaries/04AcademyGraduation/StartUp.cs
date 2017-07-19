using System;
using System.Collections.Generic;
using System.Linq;

namespace _04AcademyGraduation
{
    public class StartUp
    {
        public static void Main()
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            SortedDictionary<string, List<double>> result = new SortedDictionary<string, List<double>>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string studentName = Console.ReadLine();
                List<double> grades = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToList();

                result.Add(studentName, grades);
            }

            foreach (var student in result)
            {
                Console.WriteLine($"{student.Key} is graduated with {student.Value.Average()}");
            }
        }
    }
}
