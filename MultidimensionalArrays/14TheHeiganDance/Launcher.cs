namespace _14TheHeiganDance
{
    using System;

    public class Launcher
    {
        private const int MatrixSize = 15;
        private const int PlagueCloudDmg = 3500;
        private const int ErruptionDmg = 6000;
        private const double PlayerHealth = 18500;
        private const double HeighanHealth = 3000000;

        public static void Main()
        {
            int[] playerPosition = new int[]
            {
                MatrixSize / 2,
                MatrixSize / 2
            };
            double heighanCurrentHealth = HeighanHealth;
            double playerCurrentHealth = PlayerHealth;

            double dmgToHeighan = double.Parse(Console.ReadLine());
            bool isHeighanDead = false;
            bool isPlayerDead = false;
            bool hasPlague = false;
            string deathBy = string.Empty;

            while (true)
            {
                string[] spellTokens = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string spellName = spellTokens[0];
                int spellRow = int.Parse(spellTokens[1]);
                int spellCol = int.Parse(spellTokens[2]);

                heighanCurrentHealth -= dmgToHeighan;
                isHeighanDead = heighanCurrentHealth <= 0;
                if (hasPlague)
                {
                    playerCurrentHealth -= PlagueCloudDmg;
                    hasPlague = false;
                    isPlayerDead = playerCurrentHealth <= 0;
                }

                if (isHeighanDead || isPlayerDead)
                {
                    break;
                }

                if (IsPlayerHit(playerPosition, spellRow, spellCol))
                {
                    if (!PlayerTryEscape(playerPosition, spellRow, spellCol))
                    {
                        switch (spellName)
                        {
                            case "Cloud":
                                playerCurrentHealth -= PlagueCloudDmg;
                                hasPlague = true;
                                deathBy = "Plague Cloud";
                                break;
                            case "Eruption":
                                playerCurrentHealth -= ErruptionDmg;
                                deathBy = "Eruption";
                                break;
                        }
                    }
                }
                if (playerCurrentHealth <= 0)
                {
                    isPlayerDead = true;
                    break;
                }
            }

            PrintResult(playerPosition, playerCurrentHealth, heighanCurrentHealth, deathBy);

        }

        private static void PrintResult(int[] playerPosition, double playerCurrentHealth, double heighanCurrentHealth, string deathBy)
        {
            if (heighanCurrentHealth <= 0)
            {
                Console.WriteLine($"Heigan: Defeated!");
            }
            else
            {
                Console.WriteLine($"Heigan: {heighanCurrentHealth:f2}");
            }
            if (playerCurrentHealth <= 0)
            {
                Console.WriteLine($"Player: Killed by {deathBy}");
            }
            else
            {
                Console.WriteLine($"Player: {playerCurrentHealth}");
            }

            Console.WriteLine($"Final position: {playerPosition[0]}, {playerPosition[1]}");
        }

        private static bool PlayerTryEscape(int[] playerPosition, int spellRow, int spellCol)
        {
            if (playerPosition[0] - 1 >= 0 && playerPosition[0] - 1 < spellRow - 1)
            {
                playerPosition[0]--;
                return true;
            }
            else if (playerPosition[1] + 1 < MatrixSize && playerPosition[1] + 1 > spellCol + 1)
            {
                playerPosition[1]++;
                return true;
            }
            else if (playerPosition[0] + 1 < MatrixSize && playerPosition[0] + 1 > spellRow + 1)
            {
                playerPosition[0]++;
                return true;
            }
            else if (playerPosition[1] - 1 >= 0 && playerPosition[1] - 1 < spellCol - 1)
            {
                playerPosition[1]--;
                return true;
            }

            return false;
        }

        private static bool IsPlayerHit(int[] playerPosition, int spellRow, int spellCol)
        {
            bool isHitRow = playerPosition[0] >= spellRow - 1 && playerPosition[0] <= spellRow + 1;
            bool isHitCol = playerPosition[1] >= spellCol - 1 && playerPosition[1] <= spellCol + 1;

            return isHitRow && isHitCol;
        }
    }
}
