using System.Linq;

namespace TableTopUnitLib.Unit
{
    public class UnitStats
    {
        private Selection selection;

        public UnitStats(Profile profile)
        {
            foreach (var stats in profile.characteristics)
            {
                stats.text = new string(stats.text.Where(c => char.IsDigit(c)).ToArray());
                switch (stats.name)
                {
                    case "M":
                        Move = int.Parse(stats.text);
                        break;
                    case "T":
                        Tought = int.Parse(stats.text);
                        break;
                    case "SV":
                        Save = int.Parse(stats.text);
                        break;
                    case "W":
                        Wound = int.Parse(stats.text);
                        break;
                    case "LD":
                        Leadership = int.Parse(stats.text);
                        break;
                    case "OC":
                        ObjectiveControle = int.Parse(stats.text);
                        break;
                }
            }
        }

        int Move { get; }
        int Tought { get; }
        int Save { get; }
        int Wound { get; }
        int Leadership { get; }
        int ObjectiveControle { get; }
        int SaveInv { get; }
    }
}
