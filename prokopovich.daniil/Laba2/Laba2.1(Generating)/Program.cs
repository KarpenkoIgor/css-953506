using System;

namespace Generating
{
    class Program
    {
        static void Main(string[] args)
        {
            var chars = "abcdefghijklmnopqrstuvwxyz";
            var stringChars = new char[4];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            Console.WriteLine("Your random string is:");
            Console.WriteLine($"{finalString}");
        }
    }
}
