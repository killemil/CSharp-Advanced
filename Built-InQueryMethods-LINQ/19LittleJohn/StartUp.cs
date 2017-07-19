namespace _19LittleJohn
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class StartUp
    {
        static void Main()
        {
            int smallCount = 0;
            int mediumCount = 0;
            int largeCount = 0;
            string pattern = @"(>>>----->>)|(>>----->)|(>----->)";
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 4; i++)
            {
                string input = Console.ReadLine();
                bool isMatch = Regex.IsMatch(input, pattern);
                if (isMatch)
                {
                    MatchCollection matches = Regex.Matches(input, pattern);
                    foreach (Match match in matches)
                    {
                        if (match.Groups[1].Success)
                        {
                            largeCount += match.Groups[1].Length / 10;
                        }
                        if (match.Groups[2].Success)
                        {
                            mediumCount += match.Groups[2].Length / 8;
                        }
                        if (match.Groups[3].Success)
                        {
                            smallCount += match.Groups[3].Length / 7;
                        }
                    }
                }
            }

            int number = int.Parse(sb.Append(smallCount).Append(mediumCount).Append(largeCount).ToString());
            sb.Clear();
            string binary = Convert.ToString(number, 2);

            var reverse = binary.ToCharArray();
            Array.Reverse(reverse);
            string reversed = new string(reverse);

            sb.Append(binary).Append(reversed);
            int result = Convert.ToInt32(sb.ToString(), 2);

            Console.WriteLine(result);
        }
    }
}
