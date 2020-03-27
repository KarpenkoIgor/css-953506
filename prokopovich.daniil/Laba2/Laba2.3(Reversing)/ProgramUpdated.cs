using System;
using System.Text;

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
            StringBuilder str = new StringBuilder("");
            for(int i=splited.Length-1;i>=0;i--)
            {
                str.Append($"{splited[i]} ");
            }
            Console.WriteLine("Your new string:");
            Console.WriteLine($"{str}");
        }
    }
}
