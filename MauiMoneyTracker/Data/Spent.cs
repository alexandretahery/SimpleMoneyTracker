using BlazorBootstrap;

namespace MauiMoneyTracker.Data
{
    public class Spent
    {
        public Guid Id { get; private set; }
        public double Amount { get; set; }
        public double Total { get; set; }
        public string Label { get; set; }
        public DateTime Date { get; set; }

        public Spent(double amount, double total, string label, DateTime date)
        {
            Id = Guid.NewGuid();
            Amount = amount;
            Total = total;
            Label = label;
            Date = DateTime.Now;
        }

        public Spent()
        {
            Id = Guid.NewGuid();
        }
    }
}
