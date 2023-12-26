using DatabaseMoneyTracker;

namespace MauiMoneyTracker.Services
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
                Spent expense = new Spent(inputAmount, inputAmount, inputLabel, inputDateTime);
                return expense;
            }
            else
            {
                Spent lastSold = Spents.Last();
                Spent expense = new Spent(inputAmount, lastSold.Total + inputAmount, inputLabel, inputDateTime);
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
            }
            else
            {
                Spent lastValue = Spents.Where(r => r.Date < newSpent.Date).Last();
                Spents.Insert(Spents.IndexOf(lastValue) + 1, newSpent);
            }
            string historyInCSV = GenerateReport(Spents);
            //WriteHistory(historyInCSV);
            OnHistoryUpdates?.Invoke(this, EventArgs.Empty);
        }

        private void WriteHistory(string historyInCSV)
        {
            using (StreamWriter writer = new StreamWriter("/"))
            {
                writer.WriteLine(historyInCSV);
            }
            string readText = File.ReadAllText("/");
            Console.WriteLine(readText);
        }

        public void RemoveRecord(Spent spent)
        {
            Spents.Remove(spent);
            OnHistoryUpdates?.Invoke(this, EventArgs.Empty);
        }

        public string GenerateReport<T>(List<T> items) where T : class
        {
            string output = string.Empty;
            char delimiter = ';';
            var properties = typeof(T).GetProperties()
            .Where(n =>
            n.PropertyType == typeof(string)
            || n.PropertyType == typeof(bool)
            || n.PropertyType == typeof(char)
            || n.PropertyType == typeof(byte)
            || n.PropertyType == typeof(decimal)
            || n.PropertyType == typeof(double)
            || n.PropertyType == typeof(int)
            || n.PropertyType == typeof(DateTime)
            || n.PropertyType == typeof(DateTime?)); using (var sw = new StringWriter())
            {
                var header = properties
                .Select(n => n.Name)
                .Aggregate((a, b) => a + delimiter + b);
                sw.WriteLine(header);
                foreach (var item in items)
                {
                    var row = properties
                    .Select(n => n.GetValue(item, null))
                    .Select(n => n == null ? "null" : n.ToString()).Aggregate((a, b) => a + delimiter + b); sw.WriteLine(row);
                }
                output = sw.ToString();
            }
            return output;
        }
    }
}
