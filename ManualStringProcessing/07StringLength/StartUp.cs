namespace _07StringLength
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            text = text.Substring(0, Math.Min(20, text.Length));
            string result = text.PadRight(20, '*');
            Console.WriteLine(result);
        }
    }
}
