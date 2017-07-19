namespace _02LineNumbers
{
    using System.IO;

    public class LineNumbers
    {
        public static void Main()
        {
            StreamReader reader = new StreamReader("../../LineNumbers.cs");
            StreamWriter writer = new StreamWriter("../../LineNumbers.txt");

            using (reader)
            {
                string line = reader.ReadLine();
                int lineNumber = 1;
                using (writer)
                {
                    while (line != null)
                    {
                        writer.WriteLine($"{lineNumber} {line}");
                        lineNumber++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
