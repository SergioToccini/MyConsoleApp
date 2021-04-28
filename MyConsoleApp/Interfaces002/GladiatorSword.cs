using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces002
{
    public class GladiatorSword : OneHandedSword
    {
        public override int MinDamage { get; set; } = 5;
        public override int MaxDamage { get; set; } = 10;
        public override int Durability { get; set; } = 30;
    }
}
