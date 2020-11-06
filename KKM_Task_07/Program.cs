using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKM_Task_07
{
    class Program
    // функцию Shuffle, который перемешивает элементы массива в случайном порядке.
    {
        public static void Shuffle<T>(T[] arr)
{
    Random rand = new Random();
 
    for (int i = arr.Length - 1; i >= 1; i--)
    {
        int j = rand.Next(i + 1);
 
        T tmp = arr[j];
        arr[j] = arr[i];
        arr[i] = tmp;
    }
}
        static void Main(string[] args)
        {

            {
                // Ввод числа n
                Console.WriteLine(" ");
                Console.WriteLine("  Введите размерность: \n");
                int n = Convert.ToInt16(Console.ReadLine());

                // Создание массива

                var mas = new int[n];

                Random rand = new Random();

                for (int i = 0; i < n; i++)
                {
                    mas[i] = rand.Next(1,10);
                }

                Console.WriteLine(" ");
                Console.WriteLine("  Массив, созданный случайным образом: \n");
                Console.WriteLine(string.Join(" ", mas));


                // Вызов функции Shuffle
                Shuffle(mas);

                Console.WriteLine(" ");
                Console.WriteLine("  Измененный массив: \n");
                Console.WriteLine(string.Join(" ", mas));
                Console.ReadKey();
                Console.ReadKey();
            }

        }
    }
}
