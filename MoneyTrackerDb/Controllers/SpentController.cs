using MoneyTrackerDb.BLL;
using MoneyTracker.Common;
using System.Collections.Generic;
using System;

namespace MoneyTrackerDb.Controllers
{
    public class SpentController
    {
        private SpentBLL _spentBll;

        public SpentController()
        {
            _spentBll = new SpentBLL();
        }

        public ISpent GetSpentById(int id)
        {
            return (ISpent)_spentBll.GetMoneySpentById(id);
        }

        public IEnumerable<ISpent> GetSpentAll()
        {
            return (IEnumerable<ISpent>)_spentBll.GetAllMoneySpent();
        }

        public IEnumerable<ISpent> GetSpentBetweenDate(DateTime dateStart, DateTime dateEnd)
        {
            return (IEnumerable<ISpent>)_spentBll.GetMoneySpentBetweenDate(dateStart, dateEnd);
        }

        public ISpent CreateSpent(ISpent moneyRecord)
        {
            return _spentBll.CreateMoneySpent(moneyRecord.SpentToMoneyRecord());
        }

        public void UpdateSpent(ISpent moneyRecord)
        {
            //_spentBll.UpdateMoneySpent(moneyRecord);
        }

        public void DeleteSpent(int id)
        {
            _spentBll.DeleteMoneySpent(id);
        }
    }
}
