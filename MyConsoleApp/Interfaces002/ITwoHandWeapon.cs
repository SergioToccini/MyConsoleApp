using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces002
{
    public interface ITwoHandWeapon
    {
        bool IsFirstHandBusy { get; set; }
        bool IsSecondHandBusy { get; set; }
    }
}
