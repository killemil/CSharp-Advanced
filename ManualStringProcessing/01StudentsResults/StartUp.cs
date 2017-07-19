namespace _01StudentsResults
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string name = "Name";
            string cadv = "CAdv";
            string coop = "COOP";
            string advop = "AdvOOP";
            string avg = "Average";
            string header = name.PadRight(10) + "|";
            header += cadv.PadLeft(7) + "|";
            header += coop.PadLeft(7) + "|";
            header += advop.PadLeft(7) + "|";
            header += avg.PadLeft(7) + "|";

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string[] arguments = Console.ReadLine().Split(new char[] { ' ', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string studentName = arguments[0];
                double firstGrade = double.Parse(arguments[1]);
                double secondGrade = double.Parse(arguments[2]);
                double thirdGrade = double.Parse(arguments[3]);
                double averageGrade = (firstGrade + secondGrade + thirdGrade) / 3;

                if (!students.ContainsKey(studentName))
                {
                    students[studentName] = new List<double>();
                }
                students[studentName].Add(firstGrade);
                students[studentName].Add(secondGrade);
                students[studentName].Add(thirdGrade);
                students[studentName].Add(averageGrade);
            }

            Console.WriteLine(header);
            foreach (var student in students)
            {

                Console.WriteLine(string.Format("{0,-10}|{1,7:f2}|{2,7:f2}|{3,7:f2}|{4,7:f4}|", student.Key, student.Value[0], student.Value[1], student.Value[2], student.Value[3]));
            }
        }
    }
}
