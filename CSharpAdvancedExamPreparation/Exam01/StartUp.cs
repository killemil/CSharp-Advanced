namespace Exam01
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main()
        {
            int maxCapacity = int.Parse(Console.ReadLine());

            Queue<string> bunkers = new Queue<string>();
            Queue<int> weapons = new Queue<int>();
            int freeCapacity = maxCapacity;

            string input;
            while ((input = Console.ReadLine()) != "Bunker Revision")
            {
                string[] inputTokens = input
               .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var element in inputTokens)
                {
                    int weapon;
                    bool isDigit = int.TryParse(element, out weapon);

                    if (!isDigit)
                    {
                        bunkers.Enqueue(element);
                    }
                    else
                    {
                        bool isSaved = false;
                        while (bunkers.Count > 1)
                        {
                            if (freeCapacity >= weapon)
                            {
                                weapons.Enqueue(weapon);
                                freeCapacity -= weapon;
                                isSaved = true;
                                break;
                            }

                            if (weapons.Count == 0)
                            {
                                Console.WriteLine($"{bunkers.Dequeue()} -> Empty");
                            }
                            else
                            {
                                Console.WriteLine($"{bunkers.Dequeue()} -> {string.Join(", ", weapons)}");
                            }
                            weapons.Clear();
                            freeCapacity = maxCapacity;
                        }

                        if (!isSaved)
                        {
                            if (weapon <= maxCapacity)
                            {
                                while (freeCapacity < weapon)
                                {
                                    freeCapacity += weapons.Dequeue();
                                }

                                weapons.Enqueue(weapon);
                                freeCapacity -= weapon;
                            }
                        }
                    }
                }
            }
        }
    }
}
