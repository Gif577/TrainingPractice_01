
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKM_Task_04
{

    class Progaram
    {
        static void Main(string[] args)
        {
            int HpBoss = 300;
            int HpPlayer = 200;
            int UltimateDamage = 0; // Если равно 3, срабатывает Атронах
            bool Attack = false;
            Random bsd = new Random(); // Создание рандома для урона Босса
            Random hlp = new Random(); // Создание рандома для прибавления здоровья
            Random kam = new Random(); // Создание рандома для пропуска хода Эйроха от Валуна

            Console.WriteLine(" ");
            Console.WriteLine("  Вы маг отшельник. Вам необходимо выполнить заказ на злого волшебника Эйроха, который держит в страхе деревню \n");
            Console.WriteLine("  Вы подошли к башне злого мага и сейчас вам предстоит сразиться с ним! \n");
            Console.WriteLine("  К счастью вы тоже умеете колдовать! \n");
            Console.WriteLine(" ");
            Console.WriteLine("  *** Вы будете получать урон в диапазоне от 10 до 80 единиц *** \n");
            Console.WriteLine(" ");
            Console.WriteLine("  Настал час битвы! \n");
            Console.WriteLine("______________________________________________________________________________________________________________________");
            Console.WriteLine(" ");
            do
            {



            chooseAgain:
                Console.WriteLine($"  Ваше здровье: {HpPlayer}");
                Console.WriteLine($"  Здоровье Эйроха: {HpBoss}\n");
                Console.WriteLine(" ");
                Console.Write("  Выберите заклинание на этот ход:\n" +
                "  1.Огненная стрела. (20 урона) \n" +
                "  2.Струя горячего воздуха.  (Выбивает из равновесия Босса при атаке на вас, а также позволяет залечить раны (+70 Здоровья)). \n" +
                "  3.Летящий валун. (При попадании с 50% вероятность оглушает босса на 1 ход ( 80 урона))\n" +
                "  4.Вы можете призвать Атронаха вам в помощь который наносит урон! (80 урона) \n" +
                "  5. Магическая сфера. Наносит едниноразовый урон по магу. (80 урона)  \n");


                int spell = 0;
                try { spell = Convert.ToInt32(Console.ReadLine()); } // Если Игрок ввел не тот тип данных
                catch
                {
                    Console.WriteLine(" ============================= ");
                    Console.WriteLine("   Ошибка! Выберите цифру! ");
                    Console.WriteLine(" ============================= ");
                    goto chooseAgain;
                }
                Console.Clear();

                int BossDamage = bsd.Next(10, 80); // Получение случайного числа (Урона Эйроха)
                int chanseHelp = hlp.Next(0, 2);  // 50% шанс на срабатывание заклинания 
                int stun = kam.Next(0, 2); // 50% шанс на пропуск хода Эйроха


                switch (spell) // Выборка 
                {
                    case (1):
                        HpBoss -= 20;
                        break;
                    case (2):
                        if (chanseHelp == 1 && Attack == true)
                        {

                            BossDamage = 0;
                            HpPlayer += 70;

                        }

                        break;
                    case (3):
                        if (stun == 1)
                        {
                            BossDamage = 0;
                        }
                        HpBoss -= 80;
                        break;
                    case (4):
                        HpBoss -= 80;
                        break;
                    case (5): //

                        UltimateDamage = UltimateDamage + 1;

                        if (UltimateDamage == 3)
                        {
                            HpBoss -= 90;


                        }
                        break;

                    default:
                        Console.WriteLine(" ");
                        Console.WriteLine("  Вы ничего не скастовали! И Эйрох воспользовался вашей ошибкой!");
                        break;


                }
                if (HpPlayer > 200) // проверка на то, что бы у игрока не было больше здоровья чем положен, и если оно выше положенного, сбрасывает до 200
                {
                    HpPlayer = 200;
                }
                HpPlayer -= BossDamage;
                Attack = true;




            } while (HpBoss >= 0 && HpPlayer >= 0); // окончание битвы при смерти 
            {
                Console.WriteLine(" ");
                Console.WriteLine("  Вы погибли... Деревня уничтожена... Эйрох одержал сокрушительную победу!");
                Console.ReadKey();

            }
            else if (HpBoss <= 0)
            {
                Console.WriteLine(" ");
                Console.WriteLine("  Вы победили злого мага Эйроха. Деревня вам благодарна!!");
                Console.ReadKey();

            }
        }

    }
}
