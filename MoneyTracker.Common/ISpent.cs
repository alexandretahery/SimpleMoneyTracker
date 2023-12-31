namespace MoneyTracker.Common
{
    public interface ISpent : IMoneyRecord
    {
        void UpdateRecord(IMoneyRecord moneyRecord);

        public string ToString();
    }
}
