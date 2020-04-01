using System;

namespace Laboratory2._1
{
    class Program
    {
        static int a, b;       
        static double condition;
        

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Interval Limits [a,b]:");
            
            Console.Write("a=");
            a = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("b=");
            b = Convert.ToInt32(Console.ReadLine());

            while (a <= b)
            {
                double t=a;
                while(t % 2 == 0) 
                {
                    condition++;
                    t /= 2;
                }
                a++;
            }
            Console.WriteLine($"Stepen chisla={condition}");            
        }
    }
}
