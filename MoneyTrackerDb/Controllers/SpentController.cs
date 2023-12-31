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
            return _spentBll.GetMoneySpentById(id);
        }

        public IEnumerable<ISpent> GetSpentAll()
        {
            return _spentBll.GetAllMoneySpent();
        }

        public IEnumerable<ISpent> GetSpentBetweenDate(DateTime dateStart, DateTime dateEnd)
        {
            return _spentBll.GetMoneySpentBetweenDate(dateStart, dateEnd);
        }

        public ISpent CreateSpent(ISpent moneyRecord)
        {
            return _spentBll.CreateMoneySpent(moneyRecord);
        }

        public ISpent UpdateSpent(ISpent moneyRecord)
        {
            return _spentBll.UpdateMoneySpent(moneyRecord);
        }

        public void DeleteSpent(int id)
        {
            _spentBll.DeleteMoneySpent(id);
        }
    }
}
