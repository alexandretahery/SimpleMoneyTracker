using MoneyTrackerDb.DAL;
using MoneyTracker.Common;
using System.Collections.Generic;
using System.Linq;
using MoneyTrackerDb.Models;

namespace MoneyTrackerDb.BLL
{
    internal class IncomeBLL
    {
        private MoneyRecordDAL _db;

        //internal IncomeBLL()
        //{
        //    _db = new MoneyRecordDb();
        //}

        //public IMoneyRecord GetMoneyIncomeById(int id)
        //{
        //    IMoneyRecord moneyRecord = _db.GetMoneyRecordById(id);
        //    if (moneyRecord.RecordType != RecordType.Income)
        //        return null;
        //    return moneyRecord;
        //}

        //public IEnumerable<IMoneyRecord> GetAllMoneyIncome()
        //{
        //    IEnumerable<IMoneyRecord> moneyRecords = _db.GetAllMoneyRecord();
        //    return moneyRecords.Where(m => m.RecordType == RecordType.Income);
        //}

        //public IEnumerable<IMoneyRecord> GetMoneyIncomeBetweenDate(System.DateTime dateStart, System.DateTime dateEnd)
        //{
        //    IEnumerable<IMoneyRecord> moneyRecords = _db.GetMoneyRecordBetweenDate(dateStart, dateEnd);
        //    return moneyRecords.Where(m => m.RecordType == RecordType.Income);
        //}

        //public void CreateMoneyIncome(IIncome moneyRecord)
        //{
        //    _db.InsertMoneyRecord((MoneyRecord)moneyRecord);
        //    return;
        //}

        //public void UpdateMoneyIncome(IMoneyRecord moneyRecord)
        //{
        //    if (moneyRecord.RecordType == RecordType.Spent)
        //        _db.UpdateMoneyRecord(moneyRecord);
        //    return;
        //}

        //public void DeleteMoneyIncome(int id)
        //{
        //    _db.DeleteMoneyRecord(id);
        //}
    }
}
