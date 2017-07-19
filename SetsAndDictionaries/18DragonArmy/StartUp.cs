namespace _18DragonArmy
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class StartUp
    {
        private const int DefaultDamage = 45;
        private const int DefaultHealth = 250;
        private const int DefaultArmor = 10;

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, SortedDictionary<string, int[]>> dragons = new Dictionary<string, SortedDictionary<string, int[]>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split();

                string type = input[0];
                string name = input[1];
                int damage = input[2]
                    .Equals("null") ? DefaultDamage : int.Parse(input[2]);
                int health = input[3]
                    .Equals("null") ? DefaultHealth : int.Parse(input[3]);
                int armor = input[4]
                    .Equals("null") ? DefaultArmor : int.Parse(input[4]);

                if (dragons.ContainsKey(type))
                {
                    dragons[type][name] = new int[] { damage, health, armor };
                }
                else
                {
                    dragons[type] = new SortedDictionary<string, int[]>()
                    {
                        {name, new int[]{damage, health, armor} }
                    };
                }
            }

            foreach (var dragonType in dragons)
            {
                StringBuilder dragonsInfo = new StringBuilder();
                double avrDamange = 0, avrHealth = 0, avrArmor = 0;

                foreach (var dragonName in dragonType.Value)
                {
                    dragonsInfo.Append($"-{dragonName.Key} -> damage: {dragonName.Value[0]}, health: {dragonName.Value[1]}, armor: {dragonName.Value[2]}\r\n");

                    avrDamange += dragonName.Value[0];
                    avrHealth += dragonName.Value[1];
                    avrArmor += dragonName.Value[2];
                }
                avrDamange /= dragonType.Value.Count;
                avrHealth /= dragonType.Value.Count;
                avrArmor /= dragonType.Value.Count;

                Console.WriteLine($"{dragonType.Key}::({avrDamange:f2}/{avrHealth:f2}/{avrArmor:f2})");
                Console.Write(dragonsInfo.ToString());
            }
        }
    }
}
