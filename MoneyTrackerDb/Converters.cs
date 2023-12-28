using MoneyTracker.Common;
using MoneyTrackerDb.Models;

namespace MoneyTrackerDb
{
    public static class Converters
    {
        public static MoneyRecord SpentToMoneyRecord(this IMoneyRecord spent)
        {
            return new MoneyRecord
            {
                Id = spent.Id,
                Description = spent.Description,
                Amount = spent.Amount,
                Date = spent.Date,
                Category = spent.Category,
                RecordType = spent.RecordType
            };
        }

        //public static ISpent MoneyRecordToSpent(this IMoneyRecord spent)
        //{
        //    return (ISpent)spent;
        //}

    }
}
