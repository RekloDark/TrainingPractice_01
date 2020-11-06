using System;

namespace KNV_Task_03
{
    class Program
    {
        private const string key = "Mother";
        private const string message = ("Wakati wowote 'mzuri' ni matokeo ya bidii yako na kujitolea mara kwa mara huko nyuma. Unachofanya leo ni dhamana ya matokeo ya kesho. Ikiwa unataka kuvuna faida kesho, panda mbegu kila siku! Ukidhoofisha mkusanyiko wako hata kwa dakika, bila shaka utaanza kurudi nyuma.");
        static void Main(string[] args)
        {
            int attempts = 0;
            string pass = "";
            while (!pass.Equals(key))
            {
                attempts++;
                if (attempts > 3) System.Environment.Exit(1);
                Console.WriteLine($"Введите пароль. Попытка {attempts} из 3");
                pass = Console.ReadLine();
            }
            Console.WriteLine($"Секретное сообщение: {message}");
            Console.ReadKey();
        }
    }
}