using Microsoft.EntityFrameworkCore;
using Microsoft.Maui.Devices;
using MoneyTrackerDb.Models;
using System;
using System.IO;

namespace MoneyTrackerDb
{
    // All the code in this file is included in all platforms.
    internal class MoneyTrackerDbContext : DbContext
    {
        public string DatabasePath { get; private set; }

        public DbSet<MoneyRecord> MoneyLog { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            GetPath("MonneyTracker.db");
            optionsBuilder.UseSqlite($"Filename={DatabasePath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MoneyRecord>().ToTable("MoneyRecords");
        }

        private void GetPath(string databaseName)
        {
            DatabasePath = string.Empty;
            if (DeviceInfo.Platform == DevicePlatform.Android)
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                DatabasePath = Path.Combine(path, databaseName);
            }
            else if (DeviceInfo.Platform == DevicePlatform.iOS)
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                DatabasePath = Path.Combine(path, "..", "Library", databaseName);
            }
            else
            {
                DatabasePath = Path.Combine("C:\\temp", databaseName);
            }
        }
    }
}
