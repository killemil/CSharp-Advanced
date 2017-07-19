namespace NMS
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            List<string> result = new List<string>();

            while (!input.Equals("---NMS SEND---"))
            {
                sb.Append(input);
                input = Console.ReadLine();
            }

            string delimenter = Console.ReadLine();

            string text = sb.ToString().Trim();
            sb.Clear();

            for (int i = 0; i < text.Length - 1; i++)
            {
                sb.Append(text[i]);
                if (char.ToLower(text[i]) <= char.ToLower(text[i + 1]))
                {
                    continue;
                }
                else
                {
                    result.Add(sb.ToString());
                    sb.Clear();
                }
            }

            sb.Append(text[text.Length - 1]);
            result.Add(sb.ToString());
            Console.WriteLine(string.Join(delimenter, result));
        }
    }
}
