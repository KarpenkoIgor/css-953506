using System;

namespace ЛабораторнаяСШ2._2
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = Console.ReadLine();
            string[] mstr = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string mystr in mstr)

                 Array.Reverse(mstr);
                 Console.WriteLine("reserved:");
                 for (int i = 0; i < mstr.Length; i++)
                 {
                     Console.Write(mstr[i] + " ");
                 }
                
        }
    }
}

