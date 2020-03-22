using System;
using System.Text;
namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0, lenght;
            
            StringBuilder myStringBuilder = new StringBuilder(Console.ReadLine(), 256); 
            lenght = myStringBuilder.Length;
            
            for (int i = 0; i < lenght; i++)
                if (myStringBuilder[i] == ' ')
                    counter++;
           
            myStringBuilder.Append(' ');
            lenght++;

            for (int i = 0; counter!=0; i++)
                if (myStringBuilder[i] == ' ')
                {
                    myStringBuilder.Insert(lenght+i, ' ');
                    myStringBuilder.Remove(0, i+1);
                    lenght -= (i+1);
                    counter--;
                    i = -1;
                }
                else
                {
                    myStringBuilder.Insert(lenght+i, myStringBuilder[i]);
                }

            Console.Write(myStringBuilder.ToString());

            Console.Write($"\n{myStringBuilder.MaxCapacity} \t");
        }
    }
}
