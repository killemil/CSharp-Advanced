namespace _15PredicateParty_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            List<string> people = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = Console.ReadLine();
            while (input != "Party!")
            {
                string[] tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                string firstCriteria = tokens[1];
                string secondCriteria = tokens[2];

                people = UpdateGuests(people, command, firstCriteria, secondCriteria);

                input = Console.ReadLine();
            }

            if (people.Count != 0)
            {
                Console.WriteLine(string.Join(", ", people) + " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static List<string> UpdateGuests(List<string> people, string command, string firstCriteria, string secondCriteria)
        {
            List<string> result = people;
            switch (command)
            {
                case "Remove":
                    if (firstCriteria.Equals("StartsWith"))
                    {
                        result = people.Where(p => !p.StartsWith(secondCriteria)).ToList();
                    }
                    else if (firstCriteria.Equals("EndsWith"))
                    {
                        result = people.Where(p => !p.EndsWith(secondCriteria)).ToList();
                    }
                    else if (firstCriteria.Equals("Length"))
                    {
                        result = people.Where(p => p.Length != int.Parse(secondCriteria)).ToList();
                    }
                    break;
                case "Double":
                    if (firstCriteria.Equals("StartsWith"))
                    {
                        result.AddRange(people.Where(p => p.StartsWith(secondCriteria)).ToList());
                    }
                    else if (firstCriteria.Equals("EndsWith"))
                    {
                        result.AddRange(people.Where(p => p.EndsWith(secondCriteria)).ToList());
                    }
                    else if (firstCriteria.Equals("Length"))
                    {
                        result.AddRange(people.Where(p => p.Length == int.Parse(secondCriteria)).ToList());
                    }
                    break;
            }

            return result;
        }
    }
}
