using System;
namespace labr2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            text = Console.ReadLine();
            foreach (char c in text)
            {
                int unicode = c;
                if (Char.IsUpper(c) && (unicode > 90 || unicode < 65)) Console.WriteLine(c);
            }
        }
    }
}
