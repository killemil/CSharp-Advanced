namespace _16ThePartyReservationFilterModule
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            List<string> people = Console.ReadLine().Split().ToList();
            List<string> peopleWithoutFilters = people;

            string input = Console.ReadLine();

            while (input != "Print")
            {
                string[] tokens = input.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                string filter = tokens[1];
                string criteria = tokens[2];

                switch (command)
                {
                    case "Add filter":
                        if (filter == "Starts with")
                        {
                            people = people.Where(p => !p.StartsWith(criteria)).ToList();
                        }
                        else if (filter == "Ends with")
                        {
                            people = people.Where(p => !p.EndsWith(criteria)).ToList();
                        }
                        else if (filter == "Contains")
                        {
                            people = people.Where(p => !p.Contains(criteria)).ToList();
                        }
                        else if (filter == "Length")
                        {
                            people = people.Where(p => p.Length != int.Parse(criteria)).ToList();
                        }
                        break;
                    case "Remove filter":
                        if (filter == "Starts with")
                        {
                            people.AddRange(peopleWithoutFilters.Where(p => p.StartsWith(criteria)).ToList());
                        }
                        else if (filter == "Ends with")
                        {
                            people.AddRange(people.Where(p => p.EndsWith(criteria)).ToList());
                        }
                        else if (filter == "Contains")
                        {
                            people.AddRange(people.Where(p => p.Contains(criteria)).ToList());
                        }
                        else if (filter == "Length")
                        {
                            people.AddRange(people.Where(p => p.Length == int.Parse(criteria)).ToList());
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", people));
        }
    }
}
