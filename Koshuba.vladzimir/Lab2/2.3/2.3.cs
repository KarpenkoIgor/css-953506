using System;
using System.Numerics;

namespace _2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong a, b, n = 0;
            while (true)
            {
                Console.WriteLine("a < b");
                Console.Write("a = ");
                a = Convert.ToUInt64(Console.ReadLine());
                Console.Write("b = ");
                b = Convert.ToUInt64(Console.ReadLine());
                if (a >= b)
                {
                    Console.Clear();
                    Console.WriteLine("ERROR");
                }
                else { break; }
            }

            BigInteger c = 1;//большое знаковое число
            for (ulong i = a; i <= b; i++)
            {
                c *= i;
            }
            Console.WriteLine($"Your number is : {c}" +
                $"\n");
            while (c % 2 == 0)
            {
                c /= 2;
                n++;
            }
            Console.WriteLine(c);
         
            Console.ReadKey();
            Console.Clear();
        }
    }
}
