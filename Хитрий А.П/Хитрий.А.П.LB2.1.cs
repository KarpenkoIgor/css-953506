using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main()
        {
        Console.WriteLine(DateTime.Now);
        Console.WriteLine(DateTime.Now.ToString("s"));
        string str = DateTime.Now.ToString();
        int[] mass = new int[10];
        for (int i = 0; i < str.Length; ++i)
            if (str[i] >= '0' && str[i] <= '9')
                mass[(int)(str[i] - '0')] += 1;
        for (int i = 0; i < 10; ++i)
            if (mass[i] != 0)
                Console.WriteLine(i + ": " + mass[i]);
        Console.ReadKey();
        }
    }
