namespace MoneyTracker.Common
{
    public class Income : IIncome
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public RecordType RecordType { get; set; }

        public Income(string description, double amount, DateTime date, string category)
        {
            Description = description;
            Amount = amount;
            Date = date;
            Category = category;
            RecordType = RecordType.Income;
        }

        public Income(IMoneyRecord moneyRecord)
        {
            Id = moneyRecord.Id;
            Description = moneyRecord.Description;
            Amount = moneyRecord.Amount;
            Date = moneyRecord.Date;
            Category = moneyRecord.Category;
            RecordType = moneyRecord.RecordType;
        }

        public void UpdateRecord(IMoneyRecord moneyRecord)
        {
            Id = moneyRecord.Id;
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
