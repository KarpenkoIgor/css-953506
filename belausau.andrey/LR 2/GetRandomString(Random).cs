using System;
namespace LR2_TASK_9_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            for (i = 0; i < 10; i++)
                Console.WriteLine(GetRandStr());
        }

        static string GetRandStr()
        {
            Random rand = new Random();
            int x = rand.Next(5), i;
            char[] c = new char[x];
            string str;

            for (i = 0; i < x; i++)
                c[i] = (char)rand.Next(97, 123);
            str = new string(c);
            return str;
        }
    }
}