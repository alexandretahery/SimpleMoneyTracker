using MoneyTracker.Common;
using MoneyTrackerDb.Models;

namespace MoneyTrackerDb
{
    public static class Converters
    {
        public static MoneyRecord SpentToMoneyRecord(this ISpent spent)
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

        public static ISpent MoneyRecordToSpent(this MoneyRecord moneyRecord)
        {
            if (moneyRecord is null 
                || moneyRecord.RecordType != RecordType.Spent)
                return null;
            return new Spent(moneyRecord);
        }
        
        public static MoneyRecord IncomeToMoneyRecord(this IIncome income)
        {
            return new MoneyRecord
            {
                Id = income.Id,
                Description = income.Description,
                Amount = income.Amount,
                Date = income.Date,
                Category = income.Category,
                RecordType = income.RecordType
            };
        }

        public static IIncome MoneyRecordToIncome(this MoneyRecord moneyRecord)
        {
            if (moneyRecord is null 
                               || moneyRecord.RecordType != RecordType.Income)
                return null;
            return new Income(moneyRecord);
        }
    }
}
