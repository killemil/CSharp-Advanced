namespace _18TriFunction
{
    using System;

    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string[] words = Console.ReadLine().Split();
            foreach (var word in words)
            {
                int sum = 0;
                foreach (var character in word)
                {
                    sum += character;
                    if (sum >= n)
                    {
                        Console.WriteLine(word);
                        return;
                    }
                }
            }
        }
    }
}
