using MoneyTracker.Common;
using MoneyTrackerDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace MoneyTrackerDb.DAL
{
    internal class MoneyRecordDAL
    {
        private MoneyTrackerDbContext _context;

        public MoneyRecordDAL()
        {
            _context = new MoneyTrackerDbContext();
            _context.Database.EnsureCreated();
        }

        public IEnumerable<MoneyRecord> GetAllMoneyRecord()
        {
            return _context.MoneyLog.Select(m => new MoneyRecord
            {
                Id = m.Id,
                Description = m.Description,
                Amount = m.Amount,
                Date = m.Date,
                Category = m.Category,
                RecordType = m.RecordType
            });
        }

        public MoneyRecord GetMoneyRecordById(int id)
        {
            return _context.MoneyLog.Where(m => m.Id == id).FirstOrDefault();
        }

        public IEnumerable<MoneyRecord> GetMoneyRecordBetweenDate(DateTime dateStart, DateTime dateEnd)
        {
            return _context.MoneyLog.Where(m => m.Date >= dateStart && m.Date <= dateEnd);
        }

        public IMoneyRecord InsertMoneyRecord(MoneyRecord moneyRecord)
        {
            _context.MoneyLog.Add(moneyRecord);
            _context.SaveChanges();
            return moneyRecord;
        }

        public MoneyRecord UpdateMoneyRecord(IMoneyRecord moneyRecord)
        {
            MoneyRecord recordToUpdate = _context.MoneyLog.Where(m => m.Id == moneyRecord.Id).FirstOrDefault();
            AssignForUpdate(moneyRecord, recordToUpdate);
            _context.MoneyLog.Update(recordToUpdate);
            _context.SaveChanges();
            return recordToUpdate;
        }

        private static void AssignForUpdate(IMoneyRecord moneyRecord, MoneyRecord recordToUpdate)
        {
            recordToUpdate.Description = moneyRecord.Description;
            recordToUpdate.Amount = moneyRecord.Amount;
            recordToUpdate.Date = moneyRecord.Date;
            recordToUpdate.Category = moneyRecord.Category;
            recordToUpdate.RecordType = moneyRecord.RecordType;
        }

        public void DeleteMoneyRecord(int id)
        {
            var recordToRemove = _context.MoneyLog.FirstOrDefault(m => m.Id == id);
            _context.Remove(recordToRemove);
            _context.SaveChanges();
        }
    }
}
