using SimpleMoneyTracker.Models;

namespace SimpleMoneyTracker.Services
{
    public class HistorySpents
    {
        public List<Spent> Spents { get; private set; }

        public event EventHandler OnHistoryUpdates;

        public HistorySpents() 
        {
            Spents = new List<Spent>();
        }

        /// <summary>Create a new record</summary>
        /// <param name="Spents">List of spent</param>
        /// <param name="inputAmount">Amount Spent</param>
        /// <param name="inputLabel">Label Spent</param>
        /// <param name="inputDateTime">Date Spent</param>
        /// <returns>return new obj spent with Amount calculated with history</returns>
        public Spent CreateNewRecord(double inputAmount, string inputLabel, DateTime inputDateTime)
        {
            if (!Spents.Any())
            {
                Spent expense = new Spent(inputAmount, inputLabel, inputDateTime);
                return expense;
            }
            else
            {
                Spent lastSold = Spents.Last();
                Spent expense = new Spent(lastSold.Amount + inputAmount, inputLabel, inputDateTime);
                return expense;
            }
        }

        /// <summary>Insert a new record in the list chronologically</summary>
        /// <param name="Spents">List of spents</param>
        /// <param name="newSpent">new spent to add</param>
        public void InsertChronologically(Spent newSpent)
        {
            if (!Spents.Any())
            {
                Spents.Add(newSpent);
                return;
            }
            Spent lastValue = Spents.Where(r => r.Date < newSpent.Date).Last();
            Spents.Insert(Spents.IndexOf(lastValue) + 1, newSpent);
            OnHistoryUpdates?.Invoke(this, EventArgs.Empty);
        }
    }
}
