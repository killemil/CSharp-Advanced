namespace CubicMessages
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class StartUp
    {
        static void Main()
        {
            string pattern = @"^(\d+)([a-zA-Z]+)([^a-zA-Z]*)$";

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "Over!")
            {
                int messagesLength = int.Parse(Console.ReadLine());
                Match match = Regex.Match(inputLine, pattern);

                if (match.Success)
                {
                    var prefix = match.Groups[1].Value;
                    var messege = match.Groups[2].Value;
                    var ending = string.Empty;
                    if (match.Groups[3].Success)
                    {
                        ending = match.Groups[3].Value;
                    }

                    if (messege.Length != messagesLength)
                    {
                        continue;
                    }

                    var indexes = Regex.Replace(prefix + ending, @"\D*", string.Empty);
                    StringBuilder sb = new StringBuilder();
                    foreach (var i in indexes)
                    {
                        var index = int.Parse(i.ToString());
                        if (index >= 0 && index < messagesLength)
                        {
                            sb.Append(messege[index]);
                        }
                        else
                        {
                            sb.Append(" ");
                        }
                    }

                    Console.WriteLine($"{messege} == {sb}");
                }
            }
        }
    }
}
