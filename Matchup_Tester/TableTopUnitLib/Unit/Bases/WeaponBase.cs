using System.Collections.Generic;

namespace TableTopUnitLib.Unit
{
    public class WeaponBase :EntryBase
    {
        public int Number { get; private set; }

        public WeaponProfile weaponProfile { get; private set; }

        public int Damage { get; private set; }
        public int Attack { get; private set; }
        public int ArmorPenetration { get; private set; }
        public int Strength { get; private set; }
        public List<string> KeyWords { get; private set; }
        public List<RuleEntry> rules { get; private set; }
    }
}
