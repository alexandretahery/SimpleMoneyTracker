namespace MoneyTracker.Common
{
    // All the code in this file is included in all platforms.
    public class Spent : ISpent
    {
        private int _id;

        public int Id => _id; 
        public string Description { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public RecordType RecordType { get; }

        public Spent(string description,
                double amount,
                DateTime date,
                string category)
        {
            _id = 0;
            Description = description;
            Amount = amount;
            Date = date;
            Category = category;
            RecordType = RecordType.Spent;
        }

        public Spent(IMoneyRecord moneyRecord)
        {
            _id = moneyRecord.Id;
            Description = moneyRecord.Description;
            Amount = moneyRecord.Amount;
            Date = moneyRecord.Date;
            Category = moneyRecord.Category;
            RecordType = moneyRecord.RecordType;
        }

        public void UpdateRecord(IMoneyRecord moneyRecord)
        {
            _id = moneyRecord.Id;
            Description = moneyRecord.Description;
            Amount = moneyRecord.Amount;
            Date = moneyRecord.Date;
            Category = moneyRecord.Category;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Description: {Description}, Amount: {Amount}, Date: {Date}, Category: {Category}, RecordType: {RecordType}";
        }
    }
}
