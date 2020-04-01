using System;
using System.Text;

namespace labr2._2
{
    class Program
    {
        static void Main(string[] args)

        {
            string Alphabet = "qwertyuiopasdfghjklzxcvbnm";
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder(3);
            int Position = 0;
            for (int i = 0; i < rnd.Next(1,4); i++)
            {
                Position = rnd.Next(0, Alphabet.Length - 1);
                sb.Append(Alphabet[Position]);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
