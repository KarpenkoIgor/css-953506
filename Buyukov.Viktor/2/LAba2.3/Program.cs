using System;

namespace LAba2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();           
            char[] a = new char[4];
            for (int i = 0; i < 4; i++)
            {
                a[i] = (char)rand.Next('a', 'z');
                Console.Write(a[i]);
            }
        }
    }
}
