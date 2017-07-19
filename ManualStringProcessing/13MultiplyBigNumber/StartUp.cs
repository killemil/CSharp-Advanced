namespace _13MultiplyBigNumber
{
    using System;
    using System.Numerics;

    class StartUp
    {
        static void Main()
        {
            BigInteger numberOne = BigInteger.Parse(Console.ReadLine());
            BigInteger numbertwo = BigInteger.Parse(Console.ReadLine());
            BigInteger result = numberOne + numbertwo;
            Console.WriteLine(result);
        }
    }
}
