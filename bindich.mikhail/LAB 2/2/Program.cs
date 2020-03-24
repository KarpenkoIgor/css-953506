using System;

namespace _2_2
{
    class Program
    {
        static void symbolsCount(string date)
        {
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                for (int k = 0; k < date.Length; k++)
                {
                    int intK = Convert.ToInt32(date[k]) - 48;
                    if (intK == i)
                    {
                        numbers[i]++;
                    }
                }

                Console.WriteLine($"Amount of {i} - {numbers[i]}");
            }

        }

        static void Main(string[] args)
        {
            string dateNow = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
            Console.WriteLine(dateNow);
            symbolsCount(dateNow);

            string dateNowUTC = DateTime.UtcNow.ToString("ddd, dd MMM yyy HH:mm:ss 'GMT'"); ;
            Console.WriteLine(dateNowUTC);
            symbolsCount(dateNowUTC);

        }
    }
}
