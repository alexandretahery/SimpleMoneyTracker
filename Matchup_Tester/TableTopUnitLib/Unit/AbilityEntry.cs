using System;

namespace TableTopUnitLib.Unit
{
    public class AbilityEntry : EntryBase
    {
        public AbilityEntry(Profile profil)
        {
            Name = profil.name;
            Description = profil.characteristics[0].text;
        }

        public override bool Equals(object obj)
        {
            return obj is AbilityEntry ability &&
                   Name == ability.Name &&
                   Description == ability.Description;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Description);
        }
    }
}