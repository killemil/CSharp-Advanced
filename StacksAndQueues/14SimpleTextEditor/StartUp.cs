namespace _14SimpleTextEditor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Stack<string> undoes = new Stack<string>();

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = input[0];

                if (command.Equals("1"))
                {
                    if (undoes.Count.Equals(0))
                    {
                        undoes.Push(input[1]);
                    }
                    else
                    {
                        undoes.Push(undoes.Peek() + input[1]);
                    }
                }
                else if (command.Equals("2"))
                {
                    string currentText = undoes.Peek();
                    int index = int.Parse(input[1]);
                    currentText = currentText.Substring(0, currentText.Length - index);
                    undoes.Push(currentText);
                }
                else if (command.Equals("3"))
                {
                    int index = int.Parse(input[1]);
                    Console.WriteLine(undoes.Peek()[index - 1]);
                }
                else if (command.Equals("4"))
                {
                    undoes.Pop();
                }
            }
        }
    }
}
