using System;


class Program
{
    static void Main()
    {
        string str = "123.456";
        int tochk = 0;
        for(int i=0;i<str.Length;++i)
        {
            if ((str[i] < '0' || str[i] > '9') && str[i] != '.')
                return;
            if (str[i] == '.' && tochk == 0)
                tochk = i;
        }
        double drob = 0;
        for (int i = 0; i < str.Length; ++i)
        {
            if (str[i] == '.')
            {
                ++i;
                ++tochk; 
            }
            drob += (str[i] - '0') * Math.Pow(10, tochk - i - 1);
        }
        Console.WriteLine(drob);
        Console.ReadKey();
    }
}