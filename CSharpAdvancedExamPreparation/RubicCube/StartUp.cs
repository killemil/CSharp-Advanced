
namespace RubicCube
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            int dimensionSize = int.Parse(Console.ReadLine());

            long sumOfParticles = 0;
            int changedCells = 0;
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "Analyze")
            {
                var tokens = inputLine
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (tokens.Take(3).Any(x => x < 0 || x >= dimensionSize))
                {
                    continue;
                }

                if (tokens[3] != 0)
                {
                    sumOfParticles += tokens[3];
                    changedCells++;
                }
            }

            Console.WriteLine(sumOfParticles);
            Console.WriteLine(Math.Pow(dimensionSize, 3) - changedCells);
        }
    }
}
