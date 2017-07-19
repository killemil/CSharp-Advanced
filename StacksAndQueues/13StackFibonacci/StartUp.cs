namespace _13StackFibonacci
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<ulong> fibStack = new Stack<ulong>();

            fibStack.Push(1);
            fibStack.Push(1);

            for (int i = 1; i < n; i++)
            {
                ulong firstNum = fibStack.Pop();
                ulong secondNum = fibStack.Pop();

                fibStack.Push(firstNum);
                fibStack.Push(firstNum + secondNum);
            }

            fibStack.Pop();
            Console.WriteLine(fibStack.Peek());
        }
    }
}
