using MoneyTrackerDb.BLL;
using MoneyTracker.Common;
using System;
using System.Collections.Generic;

namespace MoneyTrackerDb.Controllers
{
    public class IncomeController
    {
        private IncomeBLL _incomeBll;

        public IncomeController()
        {
            _incomeBll = new IncomeBLL();
        }

        public IIncome GetIncomeById(int id)
        {
            return _incomeBll.GetMoneyIncomeById(id);
        }

        public IEnumerable<IIncome> GetIncomeAll()
        {
            return _incomeBll.GetAllMoneyIncome();
        }

        public IEnumerable<IIncome> GetIncomeBetweenDate(DateTime dateStart, DateTime dateEnd)
        {
            return _incomeBll.GetMoneyIncomeBetweenDate(dateStart, dateEnd);
        }

        public IIncome CreateIncome(IIncome moneyRecord)
        {
            return _incomeBll.CreateMoneyIncome(moneyRecord);
        }

        public IIncome UpdateIncome(IIncome moneyRecord)
        {
            return _incomeBll.UpdateMoneyIncome(moneyRecord);
        }

        public void DeleteIncome(int id)
        {
            _incomeBll.DeleteMoneyIncome(id);
        }
    }
}
