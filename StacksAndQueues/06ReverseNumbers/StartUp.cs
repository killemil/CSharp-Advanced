namespace _06ReverseNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();

            foreach (var num in inputNumbers)
            {
                stack.Push(num);
            }

            Console.WriteLine(string.Join(" ",stack));
        }
    }
}
