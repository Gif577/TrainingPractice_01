
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKM_Task_01
{

    class Program
    {
        //Стоимость 1 кристалла
        public const int rate = 100;
        static void Main(string[] args)
        {
            Console.WriteLine(" ");
            Console.WriteLine("----------            Обмен золота       ----------");
            Console.WriteLine("----------       Курс 1 кр. = 100 золота ----------");
            Console.WriteLine(" ");
            Console.WriteLine("  - Сколько у вас золота? ");
            int gold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"  - Сколько кристаллов вы хотите купить?");
            int crystals = Convert.ToInt32(Console.ReadLine());

            // Без if/else
            try
            {
                int res = gold - crystals * rate;
                int[] arr = new int[gold + 1];
                arr[res] = 1;
                Console.WriteLine($"  - Сделка прошла успешно! У вас {res} золота и {crystals} кристаллов.");
                Console.WriteLine(" ");
                Console.WriteLine($"---------- Для выхода введите 0 и нажмите Enter  ----------");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine($"  - Сделка не удалась - у вас {gold} золота и 0 кристаллов.");
                Console.WriteLine(" ");
                Console.WriteLine($"---------- Для выхода введите 0 и нажмите Enter ----------");
                int ex = Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();
            };
        }
    }


}