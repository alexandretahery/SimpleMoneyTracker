using MoneyTrackerDb.DAL.DTO;
using MoneyTrackerDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTrackerDb.DAL
{
    internal class MoneyRecordDb
    {
        private MoneyTrackerDbContext _context;

        MoneyRecordDb()
        {
            _context = new MoneyTrackerDbContext();
        }

        public IEnumerable<MoneyRecordDto> GetAllMoneyRecord()
        {
            throw new NotImplementedException();
        }

        public MoneyRecordDto GetMoneyRecordById(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertMoneyRecord(IMoneyRecord moneyRecord)
        {
            _context.MoneyLog.Add(moneyRecord as MoneyRecord);
        }

        public void UpdateMoneyRecord(MoneyRecordDto moneyRecord)
        {
            throw new NotImplementedException();
        }

        public void DeleteMoneyRecord(int id) 
        { 
            throw new NotImplementedException();
        }
    }
}
