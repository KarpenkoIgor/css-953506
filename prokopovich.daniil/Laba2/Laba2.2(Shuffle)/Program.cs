using System;

namespace Shuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            string mystring;
            mystring = Console.ReadLine();

            char[] array = mystring.ToCharArray();
            Random rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = array[k];
                array[k] = array[n];
                array[n] = value;
            }
            mystring = new string(array);
            Console.WriteLine($"Your new string: {mystring}");
        }

    }
}
