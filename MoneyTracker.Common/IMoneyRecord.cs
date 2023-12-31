namespace MoneyTracker.Common
{
    public interface IMoneyRecord 
    {
        public int Id { get; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public RecordType RecordType { get; }
    }
}
