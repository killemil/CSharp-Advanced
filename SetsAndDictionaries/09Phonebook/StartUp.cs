namespace _09Phonebook
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (!text.Equals("search"))
            {
                string[] textArgs = text
                    .Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                string name = textArgs[0];
                string phoneNumber = textArgs[1];

                if (!phonebook.ContainsKey(name))
                {
                    phonebook[name] = "";
                }
                phonebook[name] = phoneNumber;

                text = Console.ReadLine();
            }

            text = Console.ReadLine();

            while (!text.Equals("stop"))
            {
                if (phonebook.ContainsKey(text))
                {
                    Console.WriteLine($"{text} -> {phonebook[text]}");
                }
                else
                {
                    Console.WriteLine($"Contact {text} does not exist.");
                }

                text = Console.ReadLine();
            }
        }
    }
}
