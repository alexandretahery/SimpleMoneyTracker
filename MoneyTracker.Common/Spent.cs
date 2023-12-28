namespace MoneyTracker.Common
{
    // All the code in this file is included in all platforms.
    public class Spent : ISpent
    {
        public int Id { get; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public RecordType RecordType { get; }

        public Spent(string description, double amount, DateTime date, string category)
        {
            Id = 0;
            Description = description;
            Amount = amount;
            Date = date;
            Category = category;
            RecordType = RecordType.Spent;
        }

    }
}
