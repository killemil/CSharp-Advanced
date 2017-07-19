namespace _06ActionPrint
{
    using System;

    class StartUp
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Action<string> print = str => Console.WriteLine(str);
            Print(text, print);
        }

        private static void Print(string[] text, Action<string> print)
        {
            foreach (var name in text)
            {
                print(name);
            }
        }
    }
}
