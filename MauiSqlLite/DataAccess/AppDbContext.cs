using MauiSqlLite.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Maui.Devices;
using System;
using System.IO;

namespace MauiSqlLite.DataAccess
{
    public class AppDbContext : DbContext
    {
        public string DatabasePath { get; private set; }

        public DbSet<MoneyRecords> MoneyRecords { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            GetPath("MonneyTracker.db");
            optionsBuilder.UseSqlite($"Filename={DatabasePath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MoneyRecords>().ToTable("MoneyRecords");
        }

        private void GetPath(string databaseName)
        {
            DatabasePath =string.Empty;
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
