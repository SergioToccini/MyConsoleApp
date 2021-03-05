using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.Game
{
    public class Sword : IWeapon, IName
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Use()
        {
            Console.WriteLine("Sword slash!");
        }
    }
}
