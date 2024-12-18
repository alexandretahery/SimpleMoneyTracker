using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopUnitLib.Unit
{
    public partial class ProfilUnit
    {
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

        private void profilKeyWordsExtract(List<Category> keyWord)
        {
            foreach (Category key in keyWord)
            {
                KeyWords.Add(key.name);
            }
        }

        private void weaponExtract(Selection selection)
        {
            foreach (Selection selected in selection.selections)
            {
                foreach (var profilWeapon in selected.profiles)
                {
                    if (profilWeapon.typeName == "Ranged Weapons")
                    {

                    }
                }
            }
        }

    }
}
