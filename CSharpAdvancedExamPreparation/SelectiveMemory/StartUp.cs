namespace SelectiveMemory
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main()
        {
            List<int> larryNumbers = new List<int>();
            List<int> robinNumbers = new List<int>();

            Queue<int> robinMemory = new Queue<int>();
            List<int> larryMemory = new List<int>();

            int larryPoints = 0;
            int robinPoints = 0;
            string input = Console.ReadLine();
            while (input != "END")
            {
                int number = int.Parse(input);
                robinMemory.Enqueue(number);
                larryMemory.Add(number);

                if (larryMemory.Contains(number))
                {
                    larryMemory.RemoveAt(larryMemory.IndexOf(number));
                    larryMemory.Add(number);
                }

                if (larryNumbers.Contains(number))
                {
                    larryPoints++;
                }
                else if (larryNumbers.Count == 5)
                {
                    larryNumbers.Remove(larryMemory[0]);
                    larryNumbers.Add(number);
                }
                else
                {
                    larryNumbers.Add(number);
                }

                if (robinNumbers.Contains(number))
                {
                    robinPoints++;
                }
                else if (robinNumbers.Count == 5)
                {
                    robinNumbers.Remove(robinMemory.Dequeue());
                    robinNumbers.Add(number);
                }
                else
                {
                    robinNumbers.Add(number);
                }

                input = Console.ReadLine();
            }

            if (larryPoints > robinPoints)
            {
                Console.WriteLine($"Larry {larryPoints} Wins");
            }
            else if (robinPoints > larryPoints)
            {
                Console.WriteLine($"Robin {robinPoints} Wins");
            }
            else
            {
                Console.WriteLine($"Draw {larryPoints}");
            }
        }
    }
}
