namespace _15PoisonousPlant
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int plantsNumber = int.Parse(Console.ReadLine());
            int[] plants = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] daysPlantsDie = new int[plantsNumber];
            Stack<int> previousPlants = new Stack<int>();
            previousPlants.Push(0);


            for (int i = 1; i < plantsNumber; i++)
            {
                int dayOfDeath = 0;
                while (previousPlants.Count > 0 && plants[previousPlants.Peek()] >= plants[i])
                {
                    dayOfDeath = Math.Max(dayOfDeath, daysPlantsDie[previousPlants.Pop()]);
                    daysPlantsDie[i] = dayOfDeath + 1;
                }

                previousPlants.Push(i);
            }

            Console.WriteLine(daysPlantsDie.Max());
        }
    }
}
