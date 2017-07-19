namespace _12HandsOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, HashSet<string>> people = new Dictionary<string, HashSet<string>>();

            while (!input.Equals("JOKER"))
            {
                string[] inputArgs = input
                    .Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                string name = inputArgs[0];
                string[] cards = inputArgs[1]
                    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (!people.ContainsKey(name))
                {
                    people[name] = new HashSet<string>();
                    foreach (var card in cards)
                    {
                        people[name].Add(card);
                    }
                }
                else
                {
                    foreach (var card in cards)
                    {
                        people[name].Add(card);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Key}: {GetValueOfCards(person.Value)}");
            }
        }

        private static int GetValueOfCards(HashSet<string> cards)
        {
            int sum = 0;
            foreach (var card in cards)
            {
                int multiplayer = 0;
                string cardNum = string.Empty;
                if (card.Length == 3)
                {
                    cardNum = card.Substring(0, 2);
                }
                else
                {
                    cardNum = card[0].ToString();
                }

                switch (card.Last())
                {
                    case 'C':
                        multiplayer = 1;
                        break;
                    case 'D':
                        multiplayer = 2;
                        break;
                    case 'H':
                        multiplayer = 3;
                        break;
                    case 'S':
                        multiplayer = 4;
                        break;
                    default:
                        break;
                }

                switch (cardNum)
                {
                    case "2":
                        sum += multiplayer * 2;
                        break;
                    case "3":
                        sum += multiplayer * 3;
                        break;
                    case "4":
                        sum += multiplayer * 4;
                        break;
                    case "5":
                        sum += multiplayer * 5;
                        break;
                    case "6":
                        sum += multiplayer * 6;
                        break;
                    case "7":
                        sum += multiplayer * 7;
                        break;
                    case "8":
                        sum += multiplayer * 8;
                        break;
                    case "9":
                        sum += multiplayer * 9;
                        break;
                    case "10":
                        sum += multiplayer * 10;
                        break;
                    case "J":
                        sum += multiplayer * 11;
                        break;
                    case "Q":
                        sum += multiplayer * 12;
                        break;
                    case "K":
                        sum += multiplayer * 13;
                        break;
                    case "A":
                        sum += multiplayer * 14;
                        break;
                    default:
                        break;
                }
            }
            return sum;
        }
    }
}
