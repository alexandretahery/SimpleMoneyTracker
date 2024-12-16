using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopUnitLib.Unit
{
    public class ProfilUnit
    {
        string Name { get; }
        List<string> KeyWords { get; }
        UnitStats Stats { get; }
        List<RangedWeapon> Weapons { get; }
        List<WeaponBase> WeaponsBase { get; }
    }
}
