using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string str = Console.ReadLine();

            string[] strArr;
            strArr = str.Split(' ');

            for (int i = strArr.Length - 1; i >= 0; i--)
            {
                Console.Write(strArr[i]);
                Console.Write(' ');
            }
        }
    }
}
