 using System;

namespace Laboratory2
{
    class Program
    {
        static string start;
        static char t;
        static void Main(string[] args)
        {
            Console.WriteLine("Write a string that you want to change");
            start = Console.ReadLine();
            char[] massiv = new char[start.Length];
            for (int i = 0; i < start.Length; i++)
            {
                massiv[i] = start[i];
            }

             for (int i = 0; i < massiv.Length/2; i++)
             {
                 t = massiv[i];
                 massiv[i] = massiv[massiv.Length - i - 1];
                 massiv[massiv.Length - i - 1] = t;
             }
           
            Console.WriteLine('\n');

            int j;
            int moment = 0;

            for (int i = 0; i < start.Length; i++)
            {
               
                if (massiv[i] == ' ') 
                {
                    j = i - 1;
                    for(; moment<j; moment++,j--)
                    {
                        t = massiv[moment];
                        massiv[moment] = massiv[j];
                        massiv[j] = t;
                    }
                    moment = i + 1;
                }

                if (i == start.Length - 1) 
                {
                    j = i;
                    for (; moment < j; moment++, j--)
                    {
                        t = massiv[moment];
                        massiv[moment] = massiv[j];
                        massiv[j] = t;
                    }
                }
            }

            for (int i = 0; i < start.Length; i++)
            {
                Console.Write(massiv[i]);
           }
        }
    }
}
