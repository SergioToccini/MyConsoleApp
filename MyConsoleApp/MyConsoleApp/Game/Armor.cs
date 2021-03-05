using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.Game
{
    public abstract class Armor : IName
    {
        public string Name { get; set; }
        public int Defence { get; set; }
        public bool IsEquipped { get; set; }

        public abstract void Show();
    }
}
