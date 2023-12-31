using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTracker.Common
{
    public interface IIncome : IMoneyRecord
    {
        void UpdateRecord(IMoneyRecord moneyRecord);

        public string ToString();
    }
}
