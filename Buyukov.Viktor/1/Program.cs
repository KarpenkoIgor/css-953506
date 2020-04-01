using System;

namespace ConsoleApp2
{
    class Program
    {       
        static char[] game = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int move;
        static int result = 2;
        static bool exit = false;
       
        static void Main(string[] args)
        {
           TicTacToe();                 
        }
        
        static void TicTacToe() 
        {
            while (result != 1 && result != 0)
            {
                Console.Clear();
                Console.WriteLine("Player1 use X // Player2 use O");
                Console.WriteLine("\n");
                if (player % 2 == 0)
                {
                    Console.WriteLine("Player2 move");
                }
                else
                {
                    Console.WriteLine("Player1 move");
                }
                Console.WriteLine("\n");
                Field();
                move = Int32.Parse(Console.ReadLine());

                if (game[move] != 'X' && game[move] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        game[move] = 'O';
                        player++;
                    }
                    else
                    {
                        game[move] = 'X';
                        player++;
                    }
                }
                else
                {
                    do
                    {
                        Console.WriteLine("The field {0} is engaged. Choose again. ");
                        Console.WriteLine("\n");
                        
                        move = Int32.Parse(Console.ReadLine());

                        if (game[move] != 'X' && game[move] != 'O')
                        {
                            if (player % 2 == 0)
                            {
                                game[move] = 'O';
                                player++;
                                exit = true;
                            }
                            else
                            {
                                game[move] = 'X';
                                player++;
                                exit = true;
                            }
                        }
                     
                    } while (exit != true);
                    
                }
                Console.Clear();
                Field();
                result = Check();

                if (result == 1) Console.WriteLine("Player{0} has won", (player % 2) + 1);
                else if (result == 0) Console.WriteLine("No one won");
                else Console.WriteLine("Player{0} has won", (player % 2) + 1);
                Console.WriteLine("\n");
               
            };
        }

        static void Field()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", game[1], game[2], game[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", game[4], game[5], game[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", game[7], game[8], game[9]);
            Console.WriteLine("     |     |      ");
        }

        static int Check()
            {
                // Горизонтальная проверка
                if (game[1] == game[2] && game[2] == game[3])
                {
                    return 1;
                }
                else if (game[4] == game[5] && game[5] == game[6])
                {
                    return 1;
                }
                else if (game[4] == game[5] && game[5] == game[6])
                {
                    return 1;
                }

                // Вертикальная проверка
                if (game[1] == game[4] && game[4] == game[7])
                {
                    return 1;
                }
                else if (game[2] == game[5] && game[5] == game[8])
                {
                    return 1;
                }
                else if (game[3] == game[6] && game[6] == game[9])
                {
                    return 1;
                }

                // Диагональная проверка
                if (game[1] == game[5] && game[5] == game[9])
                {
                    return 1;
                }
                else if (game[3] == game[5] && game[5] == game[7])
                {
                    return 1;
                }

                // Финальная проверка
                else if (game[1] != '1' && game[2] != '2' && game[3] != '3' && game[4] != '4' && game[5] != '5' && game[6] != '6' && game[7] != '7' && game[8] != '8' && game[9] != '9')
                {
                    return 0;
                }

            return 2;
        }       
    }
}
