using EfDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace EfDatabase
{
    // All the code in this file is included in all platforms.
    public class DataBaseContext : DbContext
    {

        public DbSet<MoneyRecord> MoneySpends { get; set; }
        public DbSet<MoneyRecord> MoneyCredits { get; set; }


        public string DbPath { get; private set; }

        public DataBaseContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "moneytracker.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }
    }
}
