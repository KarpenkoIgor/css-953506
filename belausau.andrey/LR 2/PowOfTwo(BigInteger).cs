using System;
using System.Numerics;

namespace LR2_BigInt
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger a, b;

            Input(out a);
            Input(out b);
            Console.WriteLine();
            Console.WriteLine(solve(ref a, ref b));
        }

        static void Input(out BigInteger a)
        {
            bool flag;
            a = 0;

            do
            {
                flag = true;
                try
                {
                    Console.Write("num = ");
                    a = Convert.ToInt64(Console.ReadLine());
                }
                catch
                {
                    flag = false;
                }
            } while (!flag);
        }

        static int solve(ref BigInteger a, ref BigInteger b)
        {
            BigInteger c, temp = b;
            int n = 0;

            if (b < a)
            {
                b = a;
                a = temp;
            }

            for (c = 1; a <= b; a++)
            {
                c *= a;
                if (c == 0)
                    Environment.Exit(-1);
            }

            while (c % 2 == 0 && c != 0)
            {
                n++;
                c >>= 1;
            }

            return n;
        }
    }
}
