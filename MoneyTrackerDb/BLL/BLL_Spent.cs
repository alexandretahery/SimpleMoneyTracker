using MoneyTrackerDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTrackerDb.BLL
{
    public class MoneyRecordBLL
    {
        public IMoneyRecord Balance()
        {
            throw new NotImplementedException();
        }

        public IMoneyRecord ModifyRecord()
        {
            throw new NotImplementedException();
        }

        #region Spent

        public IMoneyRecord AddSpent()
        {
            throw new NotImplementedException();
        }

        public IMoneyRecord GetSpent()
        {
            throw new NotImplementedException();
        }

        public IMoneyRecord DeleteSpent()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Income
        public IMoneyRecord AddIncome()
        {
            throw new NotImplementedException();
        }
        public IMoneyRecord GetIncome()
        {
               throw new NotImplementedException();
        }

        public IMoneyRecord DeleteIncome()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
