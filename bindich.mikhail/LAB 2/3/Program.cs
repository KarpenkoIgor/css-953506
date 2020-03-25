using System;
using System.Text.RegularExpressions;

namespace _2_3
{
    class Program
    {
        static void stringModifier(string[] words)
        {
            string result = "";
            Regex regExpr = new Regex(@"([^A-z])+");

            for (int i = 0; i < words.Length; i++)
            {
                if (regExpr.IsMatch(words[i]))
                {
                    words[i] = regExpr.Match(words[i]) + words[i];
                }
                if (i == words.Length - 1) {
                    result += words[i];
                }
                else
                {
                    result += words[i] + ' ';
                }
            }
            Console.WriteLine($"The result string - {result}");
        }

        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string maneStr;
            maneStr = Console.ReadLine();

            string[] words = maneStr.Split(' ');
            stringModifier(words);
        }
    }
}
