
namespace _17CharacterMultiplier
{
    using System;

    class StartUp
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string firstWord = input[0];
            string secondWord = input[1];
            int maxLen = Math.Max(firstWord.Length, secondWord.Length);

            int totalSum = 0;
            for (int i = 0; i < maxLen; i++)
            {
                if (firstWord.Length - 1 < i)
                {
                    totalSum += Convert.ToInt32(secondWord[i]);
                }
                if (secondWord.Length - 1 < i)
                {
                    totalSum += Convert.ToInt32(firstWord[i]);
                }
                if (firstWord.Length - 1 >= i && secondWord.Length - 1 >= i)
                {
                    totalSum += (Convert.ToInt32(firstWord[i]) * Convert.ToInt32(secondWord[i]));
                }
            }

            Console.WriteLine(totalSum);
        }
    }
}
