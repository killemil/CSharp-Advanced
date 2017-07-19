namespace _11FixEmails
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            Dictionary<string, string> emailList = new Dictionary<string, string>();
            string input = Console.ReadLine();
            int line = 0;
            string name = string.Empty;
            while (!input.Equals("stop"))
            {
                if (line % 2 == 0)
                {
                    if (!emailList.ContainsKey(input))
                    {
                        emailList[input] = string.Empty;
                    }
                    name = input;
                }
                else
                {
                    if (input.EndsWith(".us") || input.EndsWith(".uk"))
                    {
                        emailList.Remove(name);
                    }
                    else
                    {
                        emailList[name] = input;
                    }
                }
                input = Console.ReadLine();
                line++;
            }

            foreach (var email in emailList)
            {
                Console.WriteLine($"{email.Key} -> {email.Value}");
            }   
        }
    }
}
