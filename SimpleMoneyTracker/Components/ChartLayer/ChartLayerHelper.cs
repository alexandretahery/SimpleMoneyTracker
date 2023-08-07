using SimpleMoneyTracker.Models;

namespace SimpleMoneyTracker.Components.ChartLayer
{
    public class ChartLayerHelper
    {
        /// <summary>
        /// Create a new record
        /// </summary>
        /// <param name="records">List of spent</param>
        /// <param name="inputAmount">Amount Spent</param>
        /// <param name="inputLabel">Label Spent</param>
        /// <param name="inputDateTime">Date Spent</param>
        /// <returns>return new obj spent with Amount calculated with history</returns>
        static public Spent CreateNewRecord(List<Spent> records, double inputAmount, string inputLabel, DateTime inputDateTime)
        {
            if (!records.Any())
            {
                Spent expense = new Spent(inputAmount, inputLabel, inputDateTime);
                return expense;
            }
            else
            {
                Spent lastSold = records.Last();
                Spent expense = new Spent(lastSold.Amount + inputAmount, inputLabel, inputDateTime);
                return expense;
            }
        }

        /// <summary>
        /// Insert a new record in the list chronologically
        /// </summary>
        /// <param name="records">List of spents</param>
        /// <param name="newSpent">new spent to add</param>
        static public void InsertChronologically(List<Spent> records, Spent newSpent)
        {
            if (!records.Any())
            {
                records.Add(newSpent);
                return;
            }
            Spent lastValue = records.Where(r => r.Date < newSpent.Date).Last();
            records.Insert(records.IndexOf(lastValue) + 1, newSpent);
        }
    }
}
