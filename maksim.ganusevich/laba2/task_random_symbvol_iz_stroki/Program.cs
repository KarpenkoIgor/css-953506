using System;
using System.Text;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str ="qwertyuioplkjhgfdsazxcvbnm123456qwertyuioplkjhgfdsazxcvbnm123456qwertyuioplkjhgfdsazxcvbnm123456qwertyuioplkjhgfdsazxcvbnm123456qwertyuioplkjhgfdsazxcvbnm123456qwertyuioplkjhgfdsazxcvbnm123456qwertyuioplkjhgfdsazxcvbnm123456qwertyuioplkjhgfdsazxcvbnm123456";
            Console.Write($"\n{str.Length} \n");
            
            StringBuilder newStr = new StringBuilder(30);
            Random random = new Random();

            for (int i = 0; i < 30; i++)
                newStr.Append(str[random.Next(256)]);

            Console.Write(newStr.ToString());
        }
    }
}