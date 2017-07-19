namespace _03ParseTags
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            var openTag = "<upcase>";
            var closeTag = "</upcase>";

            int startIndex = text.IndexOf(openTag);
            while (startIndex != -1)
            {
                int endIndex = text.IndexOf(closeTag);
                if (endIndex == -1)
                {
                    break;
                }
                string textToTransform = text.Substring(startIndex, (endIndex + closeTag.Length) - startIndex);
                string replaced = textToTransform.Replace(openTag, string.Empty).Replace(closeTag, string.Empty).ToUpper();
                text = text.Replace(textToTransform, replaced);

                startIndex = text.IndexOf(openTag);
            }
            Console.WriteLine(text);

        }
    }
}
