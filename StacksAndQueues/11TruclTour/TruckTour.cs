namespace _11TruclTour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TruckTour
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            char[] brackets = new char[]
            {
                '[',
                '{',
                '('
            };

            for (int i = 0; i < input.Length; i++)
            {
                if (brackets.Contains(input[i]))
                {
                    stack.Push(input[i]);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    switch (input[i])
                    {
                        case '}':
                            if (stack.Pop() != '{')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case ']':
                            if (stack.Pop() != '[')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case ')':
                            if (stack.Pop() != '(')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                    }
                }
            }
            Console.WriteLine("YES");
        }
    }
}
