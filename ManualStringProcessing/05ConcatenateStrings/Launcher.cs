namespace _05ConcatenateStrings
{
    using System;
    using System.Text;

    public class Launcher
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                sb.Append(Console.ReadLine()).Append(" ");
            }

            Console.WriteLine(sb);
        }
    }
}
