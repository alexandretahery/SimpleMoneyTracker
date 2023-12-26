using System;
using System.ComponentModel.DataAnnotations;

namespace MauiSqlLite.Models
{
    public class MoneyRecords
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
