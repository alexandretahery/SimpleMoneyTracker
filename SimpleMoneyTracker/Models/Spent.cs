namespace SimpleMoneyTracker.Models
{
    public class Spent
    {
        public Guid Id { get; private set; }
        public double Amount { get; set; }
        public string Label { get; set; }
        public DateTime Date { get; set; }

        public Spent(double amount, string label, DateTime date)
        {
            Id = Guid.NewGuid();
            Amount = amount;
            Label = label;
            Date = DateTime.Now;
        }

        public Spent()
        {
            Id = Guid.NewGuid();
        }
    }
}
