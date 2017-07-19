namespace CollectResources
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            int maxCount = 0;

            string[] validItems = { "stone", "gold", "wood", "food" };

            string[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int lines = int.Parse(Console.ReadLine());

            for (int line = 0; line < lines; line++)
            {
                bool[] usedMaterials = new bool[input.Length];

                string[] data = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int start = int.Parse(data[0]);
                int step = int.Parse(data[1]);
                int curPos = start;
                int totalCount = 0;

                while (true)
                {
                    if (usedMaterials[curPos]) break;

                    string[] item = input[curPos].Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
                    string material = item[0];

                    if (!validItems.Contains(material))
                    {
                        curPos = (curPos + step) % input.Length;
                        continue;
                    }

                    int count = item.Length == 1 ? 1 : int.Parse(item[1]);

                    totalCount += count;
                    usedMaterials[curPos] = true;
                    curPos = (curPos + step) % input.Length;
                }

                if (totalCount > maxCount) maxCount = totalCount;
            }

            Console.WriteLine(maxCount);
        }
    }
}
