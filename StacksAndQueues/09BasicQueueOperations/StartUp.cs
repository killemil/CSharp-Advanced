namespace _09BasicQueueOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();

            int n = commands[0];
            int s = commands[1];
            int x = commands[2];

            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(numbers[i]);
            }
            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count.Equals(0))
            {
                Console.WriteLine("0");
            }
            else if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                int minElement = int.MaxValue;
                while (queue.Count != 0)
                {
                    int currentNumber = queue.Dequeue();
                    if (currentNumber < minElement)
                    {
                        minElement = currentNumber;
                    }
                }

                Console.WriteLine(minElement);
            }
        }
    }
}
