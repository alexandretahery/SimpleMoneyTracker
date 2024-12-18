namespace TableTopUnitLib.Unit
{
    public class RuleEntry : EntryBase
    {
        public RuleEntry(Rule rule) {
            Name = rule.name; 
            Description = rule.description;
        }
    }
}
