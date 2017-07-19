namespace _17GroupByGroup
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            List<Person> people = new List<Person>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string fullName = tokens[0] + " " + tokens[1];
                int group = int.Parse(tokens[2]);

                Person person = new Person
                {
                    Name = fullName,
                    Group = group
                };
                people.Add(person);

                input = Console.ReadLine();
            }

            people
                .OrderBy(g => g.Group)
                .GroupBy(p => p.Group)
                .ToList()
                .ForEach(p => Console.WriteLine($"{p.Key} - {string.Join(", ", p.Select(gr => gr.Name))}"));
        }
    }
    class Person
    {
        public string Name { get; set; }

        public int Group { get; set; }
    }
}
