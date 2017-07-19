namespace _06SetsOfElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] setsLen = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int totalLen = setsLen[0] + setsLen[1];
            HashSet<int> set = new HashSet<int>();
            HashSet<int> result = new HashSet<int>();

            for (int i = 0; i < totalLen; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (set.Contains(num))
                {
                    result.Add(num);
                }
                set.Add(num);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
