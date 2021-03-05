
using MyConsoleApp.Game;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading.Tasks;

// Resharper

namespace MyConsoleApp
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
