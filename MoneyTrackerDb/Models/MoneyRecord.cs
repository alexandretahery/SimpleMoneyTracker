using System;
using System.ComponentModel.DataAnnotations;
using MoneyTracker.Common;

namespace MoneyTrackerDb.Models
{
    public class MoneyRecord : IMoneyRecord
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public RecordType RecordType { get;  set; }
    }
}
