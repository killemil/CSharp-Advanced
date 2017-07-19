namespace _17SrabskoUnleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, long>> concerts = new Dictionary<string, Dictionary<string, long>>();

            while (!input.Equals("End"))
            {
                string[] inputArgs = input
                    .Split();
                if (inputArgs.Length < 4)
                {
                    goto ignore;
                }
                else
                {
                    int lastNameIndex = input.IndexOf('@');
                    int lastIndexOfVenue = input
                        .IndexOfAny(new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' }, lastNameIndex);
                    int venueLen = lastIndexOfVenue - lastNameIndex;

                    string venue = input.Substring(lastNameIndex + 1, venueLen - 1).Trim();
                    string name = input.Substring(0, lastNameIndex).Trim();
                    long tickets = long.Parse(inputArgs[inputArgs.Length - 1]);
                    long ticketPrice = long.Parse(inputArgs[inputArgs.Length - 2]);
                    long totalTickets = tickets * ticketPrice;

                    if (!concerts.ContainsKey(venue))
                    {
                        concerts[venue] = new Dictionary<string, long>();
                        concerts[venue][name] = totalTickets;
                    }
                    else
                    {
                        if (!concerts[venue].ContainsKey(name))
                        {
                            concerts[venue][name] = totalTickets;
                        }
                        else
                        {
                            concerts[venue][name] += totalTickets;
                        }
                    }
                }
                ignore:
                input = Console.ReadLine();
            }

            foreach (var concert in concerts)
            {
                Console.WriteLine($"{concert.Key}");
                foreach (var singer in concert.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
