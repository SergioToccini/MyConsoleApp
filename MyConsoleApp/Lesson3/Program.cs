using System;
using Lesson3.Game;

// Resharper

namespace Lesson3
{
    partial class Program
    {
        public static void Main(string[] args)
        {
            Axe axe = new Axe();
            Bazuka bazuka = new Bazuka();
            DragonArmor dragonArmor = new DragonArmor();

            Player player = new Player(bazuka, dragonArmor);
            player.UseWeapon();
            player.ShowArmor();

            Console.ReadKey();
        }


    }
}
