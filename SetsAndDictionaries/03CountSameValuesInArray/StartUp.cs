namespace _03CountSameValuesInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            double[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            SortedDictionary<double, int> result = new SortedDictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!result.ContainsKey(input[i]))
                {
                    result[input[i]] = 0;
                }
                result[input[i]]++;
            }

            foreach (var num in result)
            {
                Console.WriteLine($"{num.Key} - {num.Value} times");
            }
        }
    }
}
