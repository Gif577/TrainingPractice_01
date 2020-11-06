using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KKM_Task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            //ввод 
            int[,] mas = new int[,]
            {
                {4,9,9,9,9,7,9,9,9,5},
                {1,0,0,0,0,1,0,0,0,1},
                {1,0,4,5,0,1,0,1,0,1},
                {8,9,11,6,0,1,0,1,0,1},
                {1,0,0,0,0,1,0,1,0,1},
                {8,9,0,9,9,6,0,1,0,1},
                {1,0,0,0,0,0,0,1,0,1},
                {1,0,9,9,7,9,9,6,0,1},
                {1,0,0,0,1,0,0,0,0,1},
                {3,9,9,9,11,9,2,9,9,6}
            };
            //координаты игрока
            int x = 1, y = 1;
            while (true)
            {
                //рисуем лабиринт
                Console.Clear();
                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    for (int j = 0; j < mas.GetLength(1); j++)
                    {
                        if (mas[i, j] == 0) Console.Write(".");
                        if (mas[i, j] == 1) Console.Write("║");
                        if (mas[i, j] == 3) Console.Write("╚");
                        if (mas[i, j] == 9) Console.Write("═");
                        if (mas[i, j] == 4) Console.Write("╔");
                        if (mas[i, j] == 5) Console.Write("╗");
                        if (mas[i, j] == 6) Console.Write("╝");
                        if (mas[i, j] == 8) Console.Write("╠");
                        if (mas[i, j] == 7) Console.Write("╦");
                        if (mas[i, j] == 11) Console.Write("╩");
                        if (mas[i, j] == 2) Console.Write(".");

                    }
                    Console.WriteLine();
                }
                Console.CursorLeft = x;
                Console.CursorTop = y;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("■");
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.Black;

                // обработка ввода
                ConsoleKeyInfo ki = Console.ReadKey();
                if (ki.Key == ConsoleKey.Escape) break;
                if (ki.Key == ConsoleKey.LeftArrow && mas[y, x - 1] == 0) x--;
                if (ki.Key == ConsoleKey.RightArrow && mas[y, x + 1] == 0) x++;
                if (ki.Key == ConsoleKey.UpArrow && mas[y - 1, x] == 0) y--;
                if (ki.Key == ConsoleKey.DownArrow && mas[y + 1, x] == 0) y++;
                if (ki.Key == ConsoleKey.DownArrow && mas[y + 1, x] == 2)
                {
                    y++;
                    break;
                }
            }
      
        }
    }
}