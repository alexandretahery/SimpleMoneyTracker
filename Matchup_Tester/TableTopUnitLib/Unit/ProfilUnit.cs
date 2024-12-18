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

            profilKeyWords(selection.categories)
            profilExtract(selection);
            ruleExtract(selection);
        }

        private void ruleExtract(Selection selection)
        {
            foreach (Rule rule in selection.rules)
            {
                Rules.Add(new RuleEntry(rule));
            }
        }

        private void profilExtract(Selection selection)
        {
            foreach (var profil in selection.profiles)
            {
                switch (profil.typeName)
                {
                    case "Unit":
                        Stats = new UnitStats(profil);
                        break;
                    case "Abilities":
                        Abilities.Add(new AbilityEntry(profil));
                        break;
                    default:
                        throw new Exception(profil.name);
                }
            }

        }

        private void profilKeyWords(List<Category> keyWord)
        {
            foreach (Category key in keyWord)
            {
                KeyWords.Add(key);
            }
        }

        public int Effectivy { get; private set; }
        public string Name { get; private set; }
        public List<string> KeyWords { get; private set; }
        public UnitStats Stats { get; private set; }
        public List<RangedWeapon> Weapons { get; private set; }
        public List<WeaponBase> WeaponsBase { get; private set; }
        public List<AbilityEntry> Abilities { get; private set; } = new List<AbilityEntry>();
        public List<RuleEntry> Rules { get; private set; }
    }
}
