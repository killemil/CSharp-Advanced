using System;
using System.Collections.Generic;
using System.Linq;

namespace _01ReverseStrings
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Stack<int> result = new Stack<int>();

            if (input == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                while (input > 0)
                {
                    result.Push(input % 2);
                    input /= 2;
                }
            }

            while (result.Count > 0)
            {
                Console.Write(result.Pop());
            }

            Console.WriteLine();
        }
    }
}
