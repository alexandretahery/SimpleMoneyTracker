using MoneyTrackerDb.DAL;
using MoneyTracker.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using MoneyTrackerDb.Models;

namespace MoneyTrackerDb.BLL
{
    internal class SpentBLL
    {
        private MoneyRecordDAL _db;

        internal SpentBLL()
        {
            _db = new MoneyRecordDAL();
        }

        public ISpent GetMoneySpentById(int id)
        {
            return _db.GetMoneyRecordById(id).MoneyRecordToSpent();
        }

        public IEnumerable<ISpent> GetAllMoneySpent()
        {
            return _db.GetAllMoneyRecord().Where(m => m.RecordType == RecordType.Spent)
                                          .Select(moneyRecords => moneyRecords.MoneyRecordToSpent());
        }

        public IEnumerable<ISpent> GetMoneySpentBetweenDate(DateTime dateStart, DateTime dateEnd)
        {
            return _db.GetMoneyRecordBetweenDate(dateStart, dateEnd).Where(m => m.RecordType == RecordType.Spent)
                                                                 .Select(moneyRecords => moneyRecords.MoneyRecordToSpent());
        }

        public ISpent CreateMoneySpent(ISpent spent)
        {
            IMoneyRecord moneyRecordSaved = _db.InsertMoneyRecord(spent.SpentToMoneyRecord());
            spent.UpdateRecord(moneyRecordSaved);
            return spent;
        }

        public ISpent UpdateMoneySpent(ISpent spent)
        {
            IMoneyRecord moneyRecordSaved = _db.UpdateMoneyRecord(spent.SpentToMoneyRecord());
            spent.UpdateRecord(moneyRecordSaved);
            return spent;
        }

        public void DeleteMoneySpent(int id)
        {
            _db.DeleteMoneyRecord(id);
        }
    }
}
