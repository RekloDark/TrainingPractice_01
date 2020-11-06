using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KNV_Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int crystal = 0;
            int wh2 = 1;
            int crystal_none;
            Console.Write("Для начала игры нажмите любую клавишу(Q - выход)");
            ConsoleKeyInfo choice = Console.ReadKey();
            while (choice.Key != ConsoleKey.Q && wh2 == 1)
            {
                Console.Clear();
                Console.Write("Введите количество золота: ");
                int zoloto = Convert.ToInt32(Console.ReadLine());
                while (zoloto < 0)
                {
                    Console.Clear();
                    Console.Write("******Количество кристаллов не может быть меньше нуля******\nВведите другое кол-во золота: ");
                    zoloto = Convert.ToInt32(Console.ReadLine());
                }
                Console.Clear();
                Console.Write("Введите цену за 1 кристалл: ");
                int price_crystal = Convert.ToInt32(Console.ReadLine());
                while (price_crystal < 0)
                {
                    Console.Clear();
                    Console.Write("******Цена не может быть ниже нуля******\nВведите другую цену: ");
                    price_crystal = Convert.ToInt32(Console.ReadLine());
                }
                crystal_none = zoloto - 1 * price_crystal;
                while (wh2 == 1)
                {
                    Console.Clear();
                    Console.Write("******РЮКЗАК******" + "\nКол-во кристаллов: " + crystal + "\nКол-во золота: " + zoloto + "\n\nЦена кристалла: " + price_crystal + "\nСколько кристаллов вы хотите купить(шт.): ");
                    int amount_crystal = Convert.ToInt32(Console.ReadLine());
                    while(amount_crystal<0)
                    {
                        Console.Clear();
                        Console.Write("******Количество кристаллов не может быть меньше нуля******\nВведите кол-во кристаллов для покупки: ");
                        amount_crystal = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.Clear();
                    while (zoloto - amount_crystal * price_crystal < 0)
                    {
                        Console.Clear();
                        Console.WriteLine("У вас не хватает золота, введите другое количество кристаллов: ");
                        Console.Write("Максимум вы можете себе позволить: " + (zoloto / price_crystal) + "\n Сколько купим кристаллов: ");
                        amount_crystal = Convert.ToInt32(Console.ReadLine());
                    } 
                    while (amount_crystal < 0)
                    {
                        Console.Clear();
                        Console.Write("******Количество кристаллов не может быть меньше нуля******\nВведите кол-во кристаллов для покупки: ");
                        amount_crystal = Convert.ToInt32(Console.ReadLine());
                    }
                    zoloto = zoloto - amount_crystal * price_crystal;
                    crystal = crystal + amount_crystal;
                    Console.Clear();
                    Console.Write("******РЮКЗАК******" + "\nКол-во кристаллов: " + crystal + "\nКол-во золота: " + zoloto + "\n\nХотите купить еще?\n1 - Да\n2 - Нет\nОтвет:");
                    wh2 = Convert.ToInt32(Console.ReadLine());
                    while (wh2 != 1 && wh2!=2)
                    {
                        Console.Clear();
                        Console.Write("******НЕКОРРЕКТНЫЙ ОТВЕТ******\n1 - Да\n2 - Нет\nОтвет:");
                        wh2 = Convert.ToInt32(Console.ReadLine());
                    }

                }

            }
            Console.WriteLine("Вы вышли из игры, возвращайтесь снова");
            Console.ReadKey();
        }
    }
}