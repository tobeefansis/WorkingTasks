using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    public class ConsoleLogger
    {
        const int whithInBlock = 70;
        const int whith = 80;
        const char upLeft = '╔';
        const char downLeft = '╚';
        const char upRigth = '╗';
        const char downRight = '╝';
        const char vertical = '║';
        const char horithontal = '═';



        public static void StartBlock(ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;

            int w = whith;
            string up = ""+upLeft;
            for (int i = 0; i < w - 2; i++)
            {
                up += horithontal;
            }
            up += upRigth;
            Console.WriteLine(up);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void EndBlock(ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            int w = whith;
            string down = "" + downLeft;
            for (int i = 0; i < w - 2; i++)
            {
                down += horithontal;
            }
            down += downRight;
            Console.WriteLine(down);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void LogWithoutNumber(string str)
        {
            Console.WriteLine($"│{str,-(whith - 2)}│");
        }

        public static void LogCenter(string text, ConsoleColor color = ConsoleColor.White, ConsoleColor background = ConsoleColor.White)
        {
            Console.ForegroundColor = background;
            Console.Write(vertical);
            int count = (whith - 2) - text.Length;

            string enterLine = new String(' ', count / 2);
            Console.Write(enterLine);
            for (int i = 0; i < text.Length; i++)
            {
                Console.ForegroundColor = color;
                if (char.IsNumber(text[i]))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                Console.Write(text[i]);
            }
            if (count > count / 2 * 2) //Очень важная часть ибо она убирает остаток(я знаю что можно просто проверять на четность но мне лень)
            {
                enterLine += " ";
            }
            Console.Write(enterLine);
            Console.ForegroundColor = background;
            Console.WriteLine(vertical);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void Log(object obj, ConsoleColor color = ConsoleColor.White, ConsoleColor background = ConsoleColor.White) => Log(obj.ToString(), color, background);

        public static void Log(string text, ConsoleColor color = ConsoleColor.White, ConsoleColor background = ConsoleColor.White)
        {
            int count = text.Length;
            List<string> lines = new List<string>();
            while (count >= whithInBlock)
            {

                string line = text.Substring(0, whithInBlock);
                text = text.Remove(0, line.Length);
                count -= line.Length;
                lines.Add(line);
            }
            if (text != "")
            {
                lines.Add(text);
            }
            foreach (var item in lines)
            {
                LogLine(item, color, background);
            }

        }

        static void LogLine(string text, ConsoleColor color, ConsoleColor background)
        {
            //       Console.WriteLine($"│ {str,-58}│");
            Console.ForegroundColor = background;
            Console.Write(vertical);

            for (int i = 0; i < text.Length; i++)
            {
                Console.ForegroundColor = color;
                if (char.IsNumber(text[i]))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                Console.Write(text[i]);
            }
            int count = (whith - 2) - text.Length;
            string enterLine = new String(' ', count);
            Console.Write(enterLine);
            Console.ForegroundColor = background;
            Console.WriteLine(vertical);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }
}
