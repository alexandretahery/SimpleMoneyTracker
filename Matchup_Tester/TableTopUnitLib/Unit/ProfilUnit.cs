using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopUnitLib.Unit
{
    public class ProfilUnit
    {
        public ProfilUnit(Selection selection)
        {
            Effectivy = selection.number;
            Name = selection.name;
            foreach (var profil in selection.profiles)
            {
                if (profil.typeName.Equals("Unit"))
                {
                    Stats = new UnitStats(profil);
                    break;
                }
            }
        }

        //public ProfilUnit(string name, List<string> keyWords, UnitStats stats, List<RangedWeapon> weapons, List<WeaponBase> weaponsBase)
        //{
        //    Name = name;
        //    KeyWords = keyWords;
        //    Stats = stats;
        //    Weapons = weapons;
        //    WeaponsBase = weaponsBase;
        //}
        
        int Effectivy {  get; }
        string Name { get; }
        List<string> KeyWords { get; }
        UnitStats Stats { get; }
        List<RangedWeapon> Weapons { get; }
        List<WeaponBase> WeaponsBase { get; }
        List<string> rules { get; }
    }
}
