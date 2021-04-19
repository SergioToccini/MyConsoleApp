using System;
using Lesson3.Game;

// Resharper

namespace Lesson3
{
    partial class Program
    {
        public static void Main(string[] args)
        {
            // Создаем оружие
            Axe axe = new Axe();
            Bazuka bazuka = new Bazuka();
            Sword sword = new Sword();
            DragonArmor dragonArmor = new DragonArmor();
            ShadowArmor shadowArmor = new ShadowArmor();

            // Создаем игрока
            Player player = new Player();

            // Вкладываем оружие в руку
            player.SetWeapon(axe);
            // Юзаем его
            player.UseWeapon();

            player.SetWeapon(sword);
            player.UseWeapon();

            player.SetWeapon(bazuka);
            player.UseWeapon();

            player.SetArmor(dragonArmor);
            player.ShowArmor();

            player.SetArmor(shadowArmor);
            player.ShowArmor();

            Console.ReadKey();
        }


    }
}
