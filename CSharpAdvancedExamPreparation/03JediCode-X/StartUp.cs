namespace _03JediCode_X
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    class StartUp
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < lines; i++)
            {
                sb.Append(Console.ReadLine());
            }

            string namePattern = Console.ReadLine();
            string messagePattern = Console.ReadLine();

            int[] messagesIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Regex nameRegex = new Regex(Regex.Escape(namePattern) + @"([a-zA-Z]{" + namePattern.Length + @"})(?![a-zA-Z])");
            Regex messageRegex = new Regex(Regex.Escape(messagePattern) + @"([a-zA-Z0-9]{" + messagePattern.Length + @"})(?![a-zA-Z0-9])");

            List<string> jedi = new List<string>();
            List<string> messages = new List<string>();

            MatchCollection jediMatches = nameRegex.Matches(sb.ToString());
            MatchCollection messegesMatches = messageRegex.Matches(sb.ToString());

            foreach (Match jediMatch in jediMatches)
            {
                jedi.Add(jediMatch.Groups[1].Value);
            }

            foreach (Match messageMatch in messegesMatches)
            {
                messages.Add(messageMatch.Groups[1].Value);
            }

            int currentJediIndex = 0;
            List<string> result = new List<string>();

            for (int i = 0; i < messagesIndexes.Length; i++)
            {
                if (messagesIndexes[i] - 1 < messages.Count)
                {
                    result.Add(string.Format($"{jedi[currentJediIndex]} - {messages[messagesIndexes[i] - 1]}"));
                    currentJediIndex++;
                }
                if (currentJediIndex >= jedi.Count)
                {
                    break;
                }
            }

            Console.WriteLine(string.Join("\n", result));
        }
    }
}
