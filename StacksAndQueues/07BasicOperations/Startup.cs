namespace _07BasicOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int[] amount = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();

            int elements = amount[0];
            int elemetsToPop = amount[1];
            int checkNum = amount[2];

            for (int i = 0; i < elements; i++)
            {
                stack.Push(numbers[i]);
            }
            for (int i = 0; i < elemetsToPop; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(checkNum))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                int minNumber = int.MaxValue;
                while (stack.Count != 0)
                {
                    int currentNumber = stack.Pop();

                    if (currentNumber < minNumber)
                    {
                        minNumber = currentNumber;
                    }
                }

                Console.WriteLine(minNumber);
            }
        }
    }
}
