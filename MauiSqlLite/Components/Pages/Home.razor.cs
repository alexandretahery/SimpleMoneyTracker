using MauiSqlLite.DataAccess;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;

namespace MauiSqlLite.Components.Pages
{
    public partial class Home
    {
        [Inject]
        public AppDbContext _dbContext { get; set; }

        protected override void OnInitialized()
        {
            _dbContext.SaveChanges();
            Console.WriteLine("Home.OnInitialized");
            base.OnInitialized();
        }
    }
}
