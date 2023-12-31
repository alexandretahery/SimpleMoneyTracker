using MoneyTracker.Common;
using MoneyTrackerDb.DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MoneyTrackerDb.BLL
{
    internal class IncomeBLL
    {
        private MoneyRecordDAL _db;

        internal IncomeBLL()
        {
            _db = new MoneyRecordDAL();
        }

        public IIncome GetMoneyIncomeById(int id)
        {
            return _db.GetMoneyRecordById(id).MoneyRecordToIncome();
        }

        public IEnumerable<IIncome> GetAllMoneyIncome()
        {
            return _db.GetAllMoneyRecord().Where(m => m.RecordType == RecordType.Income)
                                          .Select(moneyRecords => moneyRecords.MoneyRecordToIncome());
        }

        public IEnumerable<IIncome> GetMoneyIncomeBetweenDate(DateTime dateStart, DateTime dateEnd)
        {
            return _db.GetMoneyRecordBetweenDate(dateStart, dateEnd).Where(m => m.RecordType == RecordType.Income)
                                                                 .Select(moneyRecords => moneyRecords.MoneyRecordToIncome());
        }

        public IIncome CreateMoneyIncome(IIncome income)
        {
            IMoneyRecord moneyRecordSaved = _db.InsertMoneyRecord(income.IncomeToMoneyRecord());
            income.UpdateRecord(moneyRecordSaved);
            return income;
        }

        public IIncome UpdateMoneyIncome(IIncome income)
        {
            IMoneyRecord moneyRecordSaved = _db.UpdateMoneyRecord(income.IncomeToMoneyRecord());
            income.UpdateRecord(moneyRecordSaved);
            return income;
        }

        public void DeleteMoneyIncome(int id)
        {
            _db.DeleteMoneyRecord(id);
        }
    }
}
