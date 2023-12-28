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

        public IMoneyRecord GetMoneySpentById(int id)
        {
            IMoneyRecord moneyRecord = _db.GetMoneyRecordById(id);
            if (moneyRecord.RecordType != RecordType.Spent)
                return null;
            return moneyRecord;
        }

        public IEnumerable<IMoneyRecord> GetAllMoneySpent()
        {
            IEnumerable<IMoneyRecord> moneyRecords = _db.GetAllMoneyRecord();
            return moneyRecords.Where(m => m.RecordType == RecordType.Spent);
        }

        public IEnumerable<IMoneyRecord> GetMoneySpentBetweenDate(DateTime dateStart, DateTime dateEnd)
        {
            IEnumerable<IMoneyRecord> moneyRecords = _db.GetMoneyRecordBetweenDate(dateStart, dateEnd);
            return moneyRecords.Where(m => m.RecordType == RecordType.Spent);
        }

        public ISpent CreateMoneySpent(MoneyRecord moneyRecord)
        {
            moneyRecord.RecordType = RecordType.Spent;
            _db.InsertMoneyRecord(moneyRecord);
            //return moneyRecord.MoneyRecordToSpent();
        }

        public void UpdateMoneySpent(IMoneyRecord moneyRecord)
        {
            //if (moneyRecord.RecordType == RecordType.Spent)
            //    _db.UpdateMoneyRecord(moneyRecord);
            //return;
            return;
        }

        public void DeleteMoneySpent(int id)
        {
            _db.DeleteMoneyRecord(id);
        }
    }
}
