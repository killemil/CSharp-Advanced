
namespace _01SoftUniParty
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            SortedSet<string> partyPeople = new SortedSet<string>();

            while (!input.Equals("PARTY"))
            {
                partyPeople.Add(input);
                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (!input.Equals("END"))
            {
                partyPeople.Remove(input);
                input = Console.ReadLine();
            }

            Console.WriteLine(partyPeople.Count);

            foreach (var person in partyPeople)
            {
                Console.WriteLine(person);
            }
        }
    }
}
