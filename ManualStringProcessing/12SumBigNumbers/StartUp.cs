namespace _12SumBigNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class StartUp
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            Stack<char> firstNumber = new Stack<char>(Console.ReadLine());
            Stack<char> secondNumber = new Stack<char>(Console.ReadLine());

            int sum = 0;
            while (firstNumber.Count != 0 || secondNumber.Count != 0)
            {
                sum = sum / 10;
                if (firstNumber.Count != 0)
                {
                    sum += (int)char.GetNumericValue(firstNumber.Pop());
                }
                if (secondNumber.Count != 0)
                {
                    sum += (int)char.GetNumericValue(secondNumber.Pop());
                }

                sb.Insert(0, sum % 10);
            }

            sb.Insert(0, sum / 10);
            Console.WriteLine(sb.ToString().TrimStart('0'));
        }
    }
}
