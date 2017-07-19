namespace _02UpperStrings
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            string[] strings = Console.ReadLine().Split();
            strings.Select(str => str.ToUpper()).ToList().ForEach(str => Console.Write(str + " "));
        }
    }
}
