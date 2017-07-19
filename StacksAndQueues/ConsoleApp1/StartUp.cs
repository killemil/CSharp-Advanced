namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] children = Console.ReadLine().Split();
            Queue<string> result = new Queue<string>(children);
            int circles = int.Parse(Console.ReadLine());
            int cycle = 1;

            while (result.Count > 1)
            {
                for (int i = 1; i < circles; i++)
                {
                    result.Enqueue(result.Dequeue());
                }
                
                if (IsPrime(cycle))
                {
                    Console.WriteLine($"Prime {result.Peek()}");

                }
                else
                {
                    Console.WriteLine($"Removed {result.Dequeue()}");
                }

                cycle++;
            }

            Console.WriteLine($"Last is {result.Dequeue()}");
        }
        public static bool IsPrime(int candidate)
        {
            // Test whether the parameter is a prime number.
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }

            return candidate != 1;
        }
    }
}

