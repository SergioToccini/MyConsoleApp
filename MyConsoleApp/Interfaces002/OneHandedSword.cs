using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces002
{
    public abstract class OneHandedSword : IPhysicalWeapon, INearWeapon, IOneHandedWeapon
    {
        public int Distance { get; set; } = 1;
        public bool IsFirstHandBusy { get; set; } = true;
        public abstract int MinDamage { get; set; }
        public abstract int MaxDamage { get; set; }
        public virtual int Durability { get; set; } = 20;

        public void Use()
        {
            Console.WriteLine("Sword slash!");
        }
    }
}
