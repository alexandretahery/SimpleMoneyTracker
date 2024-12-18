using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopUnitLib.Unit
{
    public partial class ProfilUnit
    {
        public ProfilUnit(Selection selection)
        {
            Effectivy = selection.number;
            Name = selection.name;

            profilKeyWordsExtract(selection.categories);
            profilExtract(selection);
            ruleExtract(selection);
            weaponExtract(selection);
        }

        public int Effectivy { get; private set; }
        public string Name { get; private set; }
        public UnitStats Stats { get; private set; }
        public List<string> KeyWords { get; private set; } = new List<string>();
        public List<RangedWeapon> RangedWeapon { get; private set; } = new List<RangedWeapon>();
        public List<MeleeWeapon> WeaponsBase { get; private set; } = new List<MeleeWeapon>();
        public List<AbilityEntry> Abilities { get; private set; } = new List<AbilityEntry>();
        public List<RuleEntry> Rules { get; private set; } = new List<RuleEntry>();
    }
}
