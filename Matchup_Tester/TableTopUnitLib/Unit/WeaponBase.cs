using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopUnitLib.Unit
{
    public class WeaponBase
    {
        string Name { get; }
        string Description { get; }
        int number { get; }
        int Damage { get; }
        int Attack { get; }
        int ArmorPenetration { get; }
        int Strength { get; }
        List<string> KeyWords { get; }

    }
}
