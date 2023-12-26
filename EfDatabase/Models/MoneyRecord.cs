namespace EfDatabase.Models
{
    public class MoneyRecord
    {
        public Guid Id { get;}
        public double Amount { get;}
        public string Label { get;}
        public DateTime Date { get;}

        public MoneyRecord(double amount, double total, string label, DateTime date)
        {
            Id = Guid.NewGuid();
            Amount = amount;
            Label = label;
            Date = DateTime.Now;
        }
    }
}
