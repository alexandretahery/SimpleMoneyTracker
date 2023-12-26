using MoneyTrackerDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTrackerDb.DAL.DTO
{
    internal class MoneyRecordDto : DTOBase, IMoneyRecord
    {

        public int Id { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public RecordType recordType { get; set; }

        public MoneyRecordDto()
        {
            Id = Int_NullValue;
            Description = String_NullValue;
            Amount = Double_NullValue;
            Date = DateTime_NullValue;
            Category = String_NullValue;
            Type = String_NullValue;
            IsNew = true;
            recordType = recordType_NullValue;
        }

    }
}
