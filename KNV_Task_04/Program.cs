using System;

namespace KNV_Task_04
{
    public class Player
    {
        public int health;

        public int spellDamage(string spell)
        {
            int damage;
            int playerDamage;

            switch (spell.ToLower())
            {
                case "frostbolt":
                    damage = 100;
                    Console.WriteLine("Вы нанесли " + damage + " урона противнику.");
                    return damage;
                case "fireball":
                    damage = 200;
                    Console.WriteLine("Вы нанесли " + damage + " урона противнику.");
                    return damage;
                case "blizzard":
                    damage = 300;
                    playerDamage = 70;
                    health -= playerDamage;
                    Console.WriteLine("Вы нанесли " + damage + " урона противнику. Но вы сами попали под метель и получили " + playerDamage + " урона.");
                    return damage;
                case "lightning strike":
                    damage = 300;
                    playerDamage = 170;
                    health -= playerDamage;
                    Console.WriteLine("Вы нанесли " + damage + " урона противнику. Но молния попала и в вас, вы получили " + playerDamage + " урона.");
                    return damage;
                case "cup of tea":
                    if (health <= 100)
                    {
                        health += 80;
                        Console.WriteLine("Вы выпили чашку чая и чувствуете себя лучше.");
                    }
                    else
                        Console.WriteLine("Вы можете использовать это заклинание только, когда у вас меньше чем 100 ХП.");

                    return 0;
            }
            Console.WriteLine("Вы замешкались и не использовали заклинание.");
            return 0;
        }
    }

    public class Enemy
    {
        public int health;
        public int attackStrength = 55;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Player player = new Player();
            Enemy enemy = new Enemy();

            Console.WriteLine("Заклинания: \n" + "   Frostbolt        - наносит 100 урона противнику\n" + "   Fireball         - наносит 200 урона противнику\n" + "   Blizzard         - наносит 300 урона противнику, но вы можете сами попасть под метель\n" + "   Lightning Strike - наносит 370 урона противнику, но вы можете сами попасть под метель\n" + "   Cup of Tea       - вылечивает вас на 80 ХП, но вы не можете использовать это заклинание пока у вас больше 100 ХП.\n");

            player.health = random.Next(500, 1000);
            enemy.health = random.Next(800, 1300);

            for (int turn = 1; (player.health > 0) && (enemy.health > 0); turn++)
            {
                Console.WriteLine($"{turn} ход. ");
                Console.WriteLine($"У вас {player.health} ХП. У противника - {enemy.health}.");
                Console.WriteLine("\nЗаклинание: ", false);
                string spell = Console.ReadLine();

                enemy.health -= player.spellDamage(spell);
                if (spell.ToLower() != "cup of tea")
                {
                    enemy.attackStrength = random.Next(20, 100);
                    player.health -= enemy.attackStrength;
                    Console.WriteLine($"Противник нанес вам {enemy.attackStrength} урона.");
                }

                Console.Write("\n-----\n");
            }

            Console.Clear(); // Очистка поля

            if (enemy.health <= 0)
            {
                if (player.health > 0)
                    Console.WriteLine("Вы выиграли!", true);
                else
                    Console.WriteLine("Ничья!", true);
            }
            else
                Console.WriteLine("Вы проиграли!", true);
        }
    }
}