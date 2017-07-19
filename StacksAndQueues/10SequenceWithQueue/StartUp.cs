namespace _10SequenceWithQueue
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Queue<long> myQueue = new Queue<long>();
            List<long> result = new List<long>();
            myQueue.Enqueue(number);
            result.Add(number);

            while (result.Count < 50)
            {
                long currentElement = myQueue.Dequeue();
                long firstElement = currentElement + 1;
                long secondElement = (2 * currentElement) + 1;
                long thirdElement = currentElement + 2;

                myQueue.Enqueue(firstElement);
                myQueue.Enqueue(secondElement);
                myQueue.Enqueue(thirdElement);

                result.Add(firstElement);
                result.Add(secondElement);
                result.Add(thirdElement);
            }

            for (int i = 0; i < 50; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
    }
}
