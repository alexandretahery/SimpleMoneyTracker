using Microsoft.AspNetCore.Components;
using MoneyTrackerDb;

namespace MoneyTrackerApp.Components.Pages
{
    public partial class TestRequestPage
    {
        private int currentCount = 0;

        //[Inject]
        //MoneyTrackerDbContext DbContext { get; set; }



        private void IncrementCount()
        {
            currentCount++;
        }
    }
}