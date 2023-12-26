using System;
using System.ComponentModel.DataAnnotations;

namespace MoneyTrackerDb.Models
{
    internal class MoneyRecord : IMoneyRecord
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
    }
}
