namespace _09ConvertFromBase_10Tobase_N
{
    using System;
    using System.Linq;
    using System.Numerics;

    class StartUp
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            BigInteger num = BigInteger.Parse(input[1]);
            int convertToBase = int.Parse(input[0]);
            string result = string.Empty;

            while (num > 0)
            {
                result += num % convertToBase;
                num /= convertToBase;
            }

            result = new string(result.Reverse().ToArray());
            Console.WriteLine(string.Join("", result));
        }
    }
}
