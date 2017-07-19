
namespace _04Matching_Brackets
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> result = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (ch.Equals('('))
                {
                    result.Push(i);
                }
                else if (ch.Equals(')'))
                {
                    int startIndex = result.Pop();
                    string content = input.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(content);
                }
            }
        }
    }
}
