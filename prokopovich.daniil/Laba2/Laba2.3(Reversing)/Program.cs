using System;

namespace Reversing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your string:");
            string mystring;
            mystring = Console.ReadLine();
            string[] splited = mystring.Split(' ');
            mystring = "";
            for(int i=splited.Length-1;i>=0;i--)
            {
                mystring += splited[i] + " ";
            }
            Console.WriteLine("Your new string:");
            Console.WriteLine($"{mystring}");
        }
    }
}
