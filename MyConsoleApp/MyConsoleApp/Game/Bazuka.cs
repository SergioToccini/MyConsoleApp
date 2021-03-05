using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.Game
{
    public class Bazuka : IWeapon
    {
        public void Use()
        {
            Console.WriteLine("Bazuka boom!");
        }
    }
}
