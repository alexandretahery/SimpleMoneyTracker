using Xunit;
using MoneyTrackerDb;
using MoneyTracker.Common;
using System;

namespace UnitTestProject
{
    public class TestSpentOperation
    {
        Dataservice _dataService;

        public TestSpentOperation()
        {

            _dataService = new Dataservice();
        }

        [Fact]
        public void Create()
        {
            ISpent spent = new Spent("Test", 100, DateTime.Now, "Divertisement");
            _dataService.SpentController.CreateSpent(spent);
        }

        [Fact]
        public void CreateAndRetrieve()
        {
            //ISpent spent = new Spent("Test", 100, DateTime.Now, "Divertisement");
            //spent = _dataService.SpentController.CreateSpent(spent);
            //ISpent spent = _dataService.SpentController.GetSpentById(1);
            //Assert.Equal("Test", spent.Description);
        }
    }
}