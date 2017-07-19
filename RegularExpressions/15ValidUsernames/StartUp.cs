namespace _15ValidUsernames
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class StartUp
    {
        static void Main()
        {
            string pattern = @"\b[a-zA-Z]\w{2,24}\b";
            string[] validUsernames = Console.ReadLine()
                .Split(new[] { ' ', '\\', '/', ')', '(' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(u => Regex.IsMatch(u, pattern))
                .ToArray();

            int sum = 0;
            string firstUser = string.Empty;
            string secondUser = string.Empty;
            for (int i = 1; i < validUsernames.Length; i++)
            {
                int currentSum = validUsernames[i - 1].Length + validUsernames[i].Length;
                if (currentSum > sum)
                {
                    firstUser = validUsernames[i - 1];
                    secondUser = validUsernames[i];
                    sum = currentSum;
                }
            }

            Console.WriteLine(firstUser);
            Console.WriteLine(secondUser);

        }
    }
}
