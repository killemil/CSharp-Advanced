namespace _18StudentsJoinedToSpecialties
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            List<StudentSpecialty> studentSpecilaty = new List<StudentSpecialty>();
            List<Student> students = new List<Student>();

            string input = Console.ReadLine();
            while (input != "Students:")
            {
                string[] tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string specialtyName = tokens[0] + " " + tokens[1];
                string facultyNumber = tokens[2];

                StudentSpecialty specialty = new StudentSpecialty()
                {
                    FacultyNumber = facultyNumber,
                    SpecialtyName = specialtyName
                };
                studentSpecilaty.Add(specialty);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "END")
            {
                string[] tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string facultyNumber = tokens[0];
                string name = tokens[1] + " " + tokens[2];

                Student student = new Student()
                {
                    Name = name,
                    FacultyNumber = facultyNumber
                };
                students.Add(student);

                input = Console.ReadLine();
            }

            studentSpecilaty
            .Join
            (students,
            c => c.FacultyNumber,
            s => s.FacultyNumber,
            (c, s) => new
            {
                Name = s.Name,
                FaculyNumber = s.FacultyNumber,
                Specialty = c.SpecialtyName
            })
            .OrderBy(st => st.Name)
            .ToList()
            .ForEach(st => Console.WriteLine($"{st.Name} {st.FaculyNumber} {st.Specialty}"));

        }
    }
    public class StudentSpecialty
    {
        public string SpecialtyName { get; set; }

        public string FacultyNumber { get; set; }
    }

    public class Student
    {
        public string Name { get; set; }

        public string FacultyNumber { get; set; }
    }
}
