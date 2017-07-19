namespace CubicRube
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            Stack<int> flowers = new Stack<int>(Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .Reverse());
            Stack<int> buckets = new Stack<int>(Console.ReadLine()
                .Split(' ')
                .Select(int.Parse));

            Queue<int> secondNature = new Queue<int>();
            int currentFlower = 0;

            while (flowers.Count > 0 && buckets.Count > 0)
            {
                currentFlower = flowers.Pop();

                while (buckets.Count > 0 && currentFlower - buckets.Peek() > 0)
                {
                    currentFlower -= buckets.Pop();
                }

                int reminder = 0;
                if (buckets.Count > 0)
                {
                    if (currentFlower - buckets.Peek() < 0)
                    {
                        reminder = buckets.Pop() - currentFlower;
                    }
                    else
                    {
                        secondNature.Enqueue(currentFlower);
                        buckets.Pop();
                    }
                    currentFlower = -1;

                    if (buckets.Count > 0)
                    {
                        buckets.Push(buckets.Pop() + reminder);
                    }
                    else if (reminder > 0)
                    {
                        buckets.Push(reminder);
                    }
                }
                if (currentFlower > 0)
                {
                    flowers.Push(currentFlower);
                }
            }

            if (flowers.Count > 0)
            {
                Console.WriteLine(string.Join(" ", flowers));
            }
            if (buckets.Count > 0)
            {
                Console.WriteLine(string.Join(" ", buckets));
            }

            if (secondNature.Count > 0)
            {
                Console.WriteLine(string.Join(" ", secondNature));
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
