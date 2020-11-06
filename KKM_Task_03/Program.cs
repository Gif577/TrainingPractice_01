
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KKM_Task_03
{
    class Program
    {

        public static int t = 2;
        static void Main(string[] args)
        {
            Console.WriteLine(" ");
            Console.WriteLine(" ----     Доступ к секретным документам защищен!    ---- ");
            Console.WriteLine("      Чтобы пройти дальше, необходимо ввести пароль! ");
            Console.WriteLine(" ");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("  Введите пароль: ");
                string password = Console.ReadLine();
                if (password == "Kirill")
                {

                    goto Good;

                }

                else if (t == 0)
                {
                    goto Bad;
                }
                else
                {

                    Console.WriteLine($"  Ошибка при вводе пароля, кол-во попыток: {t}");
                    t--;
                }



            }
        Bad:
            Console.WriteLine();
            Console.WriteLine(" Отказано в доступе! Вы превысили количесвто попыток!  \n");
            Console.ReadKey();
        Good:
            Console.WriteLine();
            Console.WriteLine(" Доступ разрешен! \n");
            Console.WriteLine();
            Console.WriteLine(" Добрый день. \n");
            Console.ReadKey();



        }
    }
}