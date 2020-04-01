using System;

namespace _2._00
{
    class Program
    {
        private static Random random;
        static void Main(string[] args)
        {
            bool exit = false;
            while (exit == false)
            {
                Console.WriteLine("Choose the task from 1 to 3(for quit - 0):");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Press any button to finish...");
                        exit = true;
                        break;

                    case 1:
                        Console.Clear();
                        DateTime now = DateTime.Now;
                        Console.WriteLine(now.ToString("F"));
                        Console.WriteLine(now.ToString("G"));
                        Console.WriteLine("\nThe number of digits in the date entry:");
                        string nowDate = DateTime.Now.ToString();
                        int sum = 0;
                        for (char num = '0'; num <= '9'; num++)
                        {
                            for (int g = 0; g < nowDate.Length; g++)
                            {
                                if (nowDate[g] == num)
                                {
                                    sum++;
                                }
                            }
                            Console.WriteLine("{0}:{1}", num, sum);
                            sum = 0;
                        }
                        Console.Write("\n\nPress any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Enter a string (in Russian):");
                        string str;
                        str = Convert.ToString(Console.ReadLine());
                        int n = str.Length, i;
                        for (i = 0; i < n; i++)
                            if (char.IsUpper(str[i]))
                                if (str[i] > 'A' && str[i] < 'Z') continue;
                                else Console.Write(str[i]);
                        Console.Write("\n\nPress any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        random = new Random((int)DateTime.Now.Ticks);
                        string english = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuv";
                        for (int j = 0; j < 30; j++)
                        {
                            int rand = random.Next(0, english.Length);
                           // Console.Write("{0}. ", j + 1);
                            Console.Write(english[rand]+ " ");
                            //Console.WriteLine(" Стоит на позиции {0} ", rand);
                        }
                        Console.Write("\n\nPress any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    default:
                            if (choice == 4) 
                            {
                                Console.Clear(); 
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Incorrect. Enter correct choice 1 to 3");
                                Console.WriteLine("Please press any key or '4'.....");
                                Console.ReadKey();
                                Console.Clear(); 
                            }                      
                        break;
                }
            }

        }
    }
}
