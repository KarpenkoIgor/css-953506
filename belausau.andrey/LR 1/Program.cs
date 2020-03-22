using System;

namespace LR1_try2
{
    class Program
    {
        static void Main()
        {
            int curPoints = 0, max = 0, shifts;
            char dir;
            int[,] grid = new int[,] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
            SetNum(grid);
            SetNum(grid);
            
            while (true)
            {
                MaxNum(grid, ref max);
                Console.Clear();
                ShowGrid(grid, ref curPoints, max);
                if (CheckDefeat(grid, ref curPoints) == true)
                {
                    Console.ResetColor();
                    Console.WriteLine("Loser");
                    return;
                }
                dir = Console.ReadKey().KeyChar;
                shifts = 0;
                Turn(grid, dir, ref curPoints, ref shifts);
                if(shifts > 0)
                    SetNum(grid);
                Console.ResetColor();
            }
        }

        static void ShowGrid(int[,] grid, ref int curPoints, int maxNumber)
        {
            Console.WriteLine($"Current points : {curPoints}\tMax number is {maxNumber}\n");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    switch (grid[i, j])
                    {
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write($"{grid[i, j]}\t");
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write($"{grid[i, j]}\t");
                            break;
                        case 8:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write($"{grid[i, j]}\t");
                            break;
                        case 16:
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.Write($"{grid[i, j]}\t");
                            break;
                        case 32:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"{grid[i, j]}\t");
                            break;
                        case 64:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write($"{grid[i, j]}\t");
                            break;
                        case 128:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write($"{grid[i, j]}\t");
                            break;
                        case 256:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write($"{grid[i, j]}\t");
                            break;
                        case 512:
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.Write($"{grid[i, j]}\t");
                            break;
                        case 1024:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write($"{grid[i, j]}\t");
                            break;
                        case 2048:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write($"{grid[i, j]}\t");
                            break;
                        default:
                            Console.ResetColor();
                            Console.Write($"{grid[i, j]}\t");
                            break;
                    }
                }
                Console.WriteLine("\n");
            }
        }

        static void MaxNum(int[,] grid, ref int prevMax)
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    if (prevMax < grid[i, j])
                        prevMax = grid[i, j];
        }

        static int GetNum()
        {
            Random rand = new Random();
            int x = rand.Next();

            if (x % 10 > 0)
                return 2;
            else
                return 4;
        }

        static bool CheckDefeat(int[,] grid, ref int curPoints)
        {
            int i, j;

            foreach (int x in grid)
                if (x == 0)
                    return false;
            for(i = 0; i < 3; i++)
            {
                for(j = 0; j < 4; j++)
                {
                    if (grid[i, j] == grid[i + 1, j])
                        return false;
                    if (grid[j, i] == grid[j, i + 1])
                        return false;
                }
            }
            return true;
        }

        static void SetNum(int[,] grid)
        {
            Random rand = new Random();
            while (true)
            {
                int i = rand.Next(4), j = rand.Next(4);
                if (grid[i, j] == 0)
                {
                    grid[i, j] = GetNum();
                    break;
                }
            }
        }

        static void MoveUp(int[,] grid, ref int curPoints, ref int shifts)
        {
            int j, i, p, k;

            for (j = 0; j < 4; j++)
            {
                for (i = 0; i < 3; i++)
                {
                    for (p = 0; p < 2; p++)
                    {
                        for (k = 0; k < 3; k++)
                        {
                            if (grid[k, j] == 0 && grid[k + 1, j] != 0)
                            {
                                shifts++;
                                grid[k, j] = grid[k + 1, j];
                                grid[k + 1, j] = 0;
                            }
                        }
                    }
                    if (grid[i, j] == grid[i + 1, j] && grid[i, j] != 0)
                    {
                        shifts++;
                        grid[i, j] <<= 1;
                        curPoints += grid[i, j];
                        grid[i + 1, j] = 0;
                    }
                    for (k = 0; k < 3; k++)
                    {
                        if (grid[k, j] == 0 && grid[k + 1, j] != 0)
                        {
                            shifts++;
                            grid[k, j] = grid[k + 1, j];
                            grid[k + 1, j] = 0;
                        }
                    }
                }
            }
        }

        static void MoveLeft(int[,] grid, ref int curPoints, ref int shifts)
        {
            int i, j, p, k;

            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    for (p = 0; p < 2; p++)
                    {
                        for (k = 0; k < 3; k++)
                        {
                            if (grid[i, k] == 0 && grid[i, k + 1] != 0)
                            {
                                shifts++;
                                grid[i, k] = grid[i, k + 1];
                                grid[i, k + 1] = 0;
                            }
                        }
                    }
                    if (grid[i, j] == grid[i, j + 1] && grid[i, j] != 0)
                    {
                        shifts++;
                        grid[i, j] <<= 1;
                        curPoints += grid[i, j];
                        grid[i, j + 1] = 0;
                    }
                    for (k = 0; k < 3; k++)
                    {
                        if (grid[i, k] == 0 && grid[i, k + 1] != 0)
                        {
                            shifts++;
                            grid[i, k] = grid[i, k + 1];
                            grid[i, k + 1] = 0;
                        }
                    }
                }
            }
        }

        static void MoveRight(int[,] grid, ref int curPoints, ref int shifts)
        {
            int i, j, p, k;

            for (i = 0; i < 4; i++)
            {
                for (j = 3; j > 0; j--)
                {
                    for (p = 0; p < 2; p++)
                    {
                        for (k = 3; k > 0; k--)
                        {
                            if (grid[i, k] == 0 && grid[i, k - 1] != 0)
                            {
                                shifts++;
                                grid[i, k] = grid[i, k - 1];
                                grid[i, k - 1] = 0;
                            }
                        }
                    }
                    if (grid[i, j] == grid[i, j - 1] && grid[i, j] != 0)
                    {
                        shifts++;
                        grid[i, j] <<= 1;
                        curPoints += grid[i, j];
                        grid[i, j - 1] = 0;
                    }
                    for (k = 3; k > 0; k--)
                    {
                        if (grid[i, k] == 0 && grid[i, k - 1] != 0)
                        {
                            shifts++;
                            grid[i, k] = grid[i, k - 1];
                            grid[i, k - 1] = 0;
                        }
                    }
                }
            }
        }

        static void MoveDown(int[,] grid, ref int curPoints, ref int shifts)
        {
            int i, j, p, k;

            for (j = 0; j < 4; j++)
            {
                for (i = 3; i > 0; i--)
                {
                    for (p = 0; p < 2; p++)
                    {
                        for (k = 3; k > 0; k--)
                        {
                            if (grid[k, j] == 0 && grid[k - 1, j] != 0)
                            {
                                shifts++;
                                grid[k, j] = grid[k - 1, j];
                                grid[k - 1, j] = 0;
                            }
                        }
                    }
                    if (grid[i, j] == grid[i - 1, j] && grid[i, j] != 0)
                    {
                        shifts++;
                        grid[i, j] <<= 1;
                        curPoints += grid[i, j];
                        grid[i - 1, j] = 0;
                    }
                    for (k = 3; k > 0; k--)
                    {
                        if (grid[k, j] == 0 && grid[k - 1, j] != 0)
                        {
                            shifts++;
                            grid[k, j] = grid[k - 1, j];
                            grid[k - 1, j] = 0;
                        }
                    }
                }
            }
        }

        static void Turn(int[,] grid, char direction, ref int curPoints, ref int shifts)
        {
            switch (direction)
            {
                case 'w': MoveUp(grid, ref curPoints, ref shifts); break;
                case 'a': MoveLeft(grid, ref curPoints, ref shifts); break;
                case 'd': MoveRight(grid, ref curPoints, ref shifts); break;
                case 's': MoveDown(grid, ref curPoints, ref shifts); break;
            }
        }
    }
}