﻿namespace _02SumNumbers
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Console.WriteLine(numbers.Length);
            Console.WriteLine(numbers.Sum());

        }
    }
}
