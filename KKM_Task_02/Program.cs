
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKM_Task_02
{

    class Program
    {


        static void Main(string[] args)
        {

            string word = " ";

            Console.WriteLine(" ");
            Console.WriteLine("----------          Ввод любых символов       ----------");
            Console.WriteLine(" ");
            Console.WriteLine("---------- Чтобы завершить ввод, введите exit ----------");
            Console.WriteLine(" ");

            do
            {

                word = Console.ReadLine();

            }
            while (word != ("exit"));
        }
    }
}