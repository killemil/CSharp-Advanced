namespace _10MinerTask
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            string input = Console.ReadLine();
            int line = 0;
            string resource = string.Empty;
            while (!input.Equals("stop"))
            {
                if (line % 2 == 0)
                {
                    if (!resources.ContainsKey(input))
                    {
                        resources[input] = 0;
                    }
                    resource = input;
                }
                else
                {
                    resources[resource] += int.Parse(input);
                }
                input = Console.ReadLine();
                line++;
            }

            foreach (var res in resources)
            {
                Console.WriteLine($"{res.Key} -> {res.Value}");
            }
        }
    }
}
