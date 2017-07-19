namespace _08MaximumElement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            Stack<int> numbers = new Stack<int>();
            Stack<int> maxNumbers = new Stack<int>();
            int maxNum = int.MinValue;
            for (int i = 0; i < lines; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int command = input[0];

                if (command.Equals(1))
                {
                    int number = input[1];
                    numbers.Push(number);
                    if (number > maxNum)
                    {
                        maxNum = number;
                        maxNumbers.Push(number);
                    }
                }
                else if (command.Equals(2))
                {
                    int currentNumber = numbers.Pop();
                    int currentMaxNumber = maxNumbers.Peek();

                    if (currentMaxNumber == currentNumber)
                    {
                        maxNumbers.Pop();

                        if (maxNumbers.Count > 0)
                        {
                            maxNum = maxNumbers.Peek();
                        }
                        else
                        {
                            maxNum = int.MinValue;
                        }
                    }
                }
                else
                {
                    Console.WriteLine(maxNumbers.Peek());
                }
            }
        }
    }
}
