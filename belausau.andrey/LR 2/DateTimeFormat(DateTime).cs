using System;

namespace LR2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime localDate = DateTime.Now;
            string time1 = localDate.ToString("dd MMMM yyyy hh:mm tt");
            string time2 = localDate.ToString("R");
            string time3 = localDate.ToString("O");
            char i;

            Console.WriteLine(time1);
            for (i = '0'; i <= '9'; i++)
                Console.WriteLine(i + " - " + NumOfSymbs(time1, i));

            Console.WriteLine("\n" + time2);
            for (i = '0'; i <= '9'; i++)
                Console.WriteLine(i + " - " + NumOfSymbs(time2, i));

            Console.WriteLine("\n" + time3);
            for (i = '0'; i <= '9'; i++)
                Console.WriteLine(i + " - " + NumOfSymbs(time3, i));
        }

        static int NumOfSymbs(string str, char symb)
        {
            int num = 0, i;

            for (i = 0; i < str.Length; i++)
            {
                if (str[i] == symb)
                    num++;
            }
            return num;
        }
    }
}