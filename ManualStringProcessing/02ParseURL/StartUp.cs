namespace _02ParseURL
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string url = Console.ReadLine();
            int index = url.IndexOf("://");
            int serverIndex = url.IndexOf("/", index + 3);

            if (!url.Contains("://") || serverIndex == -1)
            {
                Console.WriteLine("Invalid URL");
                return;
            }
            else if (url.Substring(index + 3).Contains("://"))
            {
                Console.WriteLine("Invalid URL");
            }
            else
            {
                Console.WriteLine($"Protocol = {url.Substring(0, index)}");
                Console.WriteLine($"Server = {url.Substring(index + 3, serverIndex - index - 3)}");
                Console.WriteLine($"Resources = {url.Substring(serverIndex + 1)}");
            }
        }
    }
}
