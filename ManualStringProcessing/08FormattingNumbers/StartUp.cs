namespace _08FormattingNumbers
{
    using System;

    class StartUp
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(new[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int firstNumber = int.Parse(numbers[0]);
            string hexadecimal = firstNumber.ToString("X");
            string binary = Convert.ToString(firstNumber, 2);
            double secondNumber = double.Parse(numbers[1]);
            double thirdNumber = double.Parse(numbers[2]);
            string firstRoundedNumber = string.Format("{0:f2}", secondNumber);
            string secondRoundedNumber = string.Format("{0:f3}", thirdNumber);

            string result = "|" + hexadecimal.PadRight(10) + "|" + binary.PadLeft(10, '0').Substring(0, 10) + "|" + firstRoundedNumber.PadLeft(10) + "|" + secondRoundedNumber.PadRight(10) + "|";
            Console.WriteLine(result);

        }
    }
}
