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
            ISpent spent = new Spent("CreateAndRetrieve", 28, DateTime.Now, "CategoryPlaceholder");
            spent = _dataService.SpentController.CreateSpent(spent);
            ISpent spentFromDb = _dataService.SpentController.GetSpentById(spent.Id);

            Assert.Equal("CreateAndRetrieve", spentFromDb.Description);
            Assert.Equal(28, spentFromDb.Amount);
            Assert.Equal("CategoryPlaceholder", spentFromDb.Category);
        }

        [Fact]
        public void CreateAndDelete()
        {
            ISpent spent = new Spent("CreateAndDelete", 28, DateTime.Now, "CategoryPlaceholder");
            spent = _dataService.SpentController.CreateSpent(spent);

            Assert.Equal("CreateAndDelete", spent.Description);
            Assert.Equal(28, spent.Amount);
            Assert.Equal("CategoryPlaceholder", spent.Category);

            _dataService.SpentController.DeleteSpent(spent.Id);
            ISpent spentFromDb = _dataService.SpentController.GetSpentById(spent.Id);

            Assert.Null(spentFromDb);
        }

        [Fact]
        public void CreateAndUpdate()
        {
            ISpent spent = new Spent("CreateAndUpdate", 28, DateTime.Now, "CategoryPlaceholder");
            spent = _dataService.SpentController.CreateSpent(spent);

            Assert.Equal("CreateAndUpdate", spent.Description);
            Assert.Equal(28, spent.Amount);
            Assert.Equal("CategoryPlaceholder", spent.Category);

            spent.Description = "CreateAndUpdateUpdated";
            spent.Amount = 100;
            spent.Category = "CategoryPlaceholderUpdated";
            spent = _dataService.SpentController.UpdateSpent(spent);

            ISpent spentFromDb = _dataService.SpentController.GetSpentById(spent.Id);

            Assert.Equal("CreateAndUpdateUpdated", spentFromDb.Description);
            Assert.Equal(100, spentFromDb.Amount);
            Assert.Equal("CategoryPlaceholderUpdated", spentFromDb.Category);
        }

        [Fact]
        public void Delete()
        {
            ISpent spent = new Spent("Delete", 28, DateTime.Now, "CategoryPlaceholder");
            spent = _dataService.SpentController.CreateSpent(spent);

            Assert.Equal("Delete", spent.Description);
            Assert.Equal(28, spent.Amount);
            Assert.Equal("CategoryPlaceholder", spent.Category);

            _dataService.SpentController.DeleteSpent(spent.Id);
            ISpent spentFromDb = _dataService.SpentController.GetSpentById(spent.Id);

            Assert.Null(spentFromDb);
        }

        [Fact]
        public void RetrieveAll()
        {
            var spentList = _dataService.SpentController.GetSpentAll();
            Assert.NotEmpty(spentList);
        }

        [Fact]
        public void RetrieveBetweenDate()
        {
            ISpent spent = new Spent("Delete", 28, DateTime.Now.AddDays(-2), "CategoryPlaceholder");
            spent = _dataService.SpentController.CreateSpent(spent);

            ISpent spent1 = new Spent("Delete", 28, DateTime.Now.AddDays(-1), "CategoryPlaceholder");
            spent1 = _dataService.SpentController.CreateSpent(spent1);

            var spentList = _dataService.SpentController.GetSpentBetweenDate(DateTime.Now.AddDays(-3), DateTime.Now.AddDays(-1));
            Assert.NotEmpty(spentList);
        }

        [Fact]
        public void RetrieveById()
        {
            var spent = _dataService.SpentController.GetSpentById(1);
            Assert.NotNull(spent);
        }
    }
}