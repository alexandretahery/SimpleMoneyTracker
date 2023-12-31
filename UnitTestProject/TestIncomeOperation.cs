using Xunit;
using MoneyTrackerDb;
using MoneyTracker.Common;
using System;

namespace UnitTestProject
{
    public class TestIncomeOperation
    {
        Dataservice _dataService = new Dataservice();

        public TestIncomeOperation()
        {
            _dataService = new Dataservice();
        }

        [Fact]
        public void Create()
        {
            IIncome income = new Income("Test", 100, DateTime.Now, "Divertisement");
            _dataService.IncomeController.CreateIncome(income);
        }

        [Fact]
        public void CreateAndRetrieve()
        {
            IIncome income = new Income("CreateAndRetrieve", 28, DateTime.Now, "CategoryPlaceholder");
            income = _dataService.IncomeController.CreateIncome(income);
            IIncome incomeFromDb = _dataService.IncomeController.GetIncomeById(income.Id);

            Assert.Equal("CreateAndRetrieve", incomeFromDb.Description);
            Assert.Equal(28, incomeFromDb.Amount);
            Assert.Equal("CategoryPlaceholder", incomeFromDb.Category);
        }

        [Fact]
        public void CreateAndDelete()
        {
            IIncome income = new Income("CreateAndDelete", 28, DateTime.Now, "CategoryPlaceholder");
            income = _dataService.IncomeController.CreateIncome(income);

            Assert.Equal("CreateAndDelete", income.Description);
            Assert.Equal(28, income.Amount);
            Assert.Equal("CategoryPlaceholder", income.Category);

            _dataService.IncomeController.DeleteIncome(income.Id);
            IIncome incomeFromDb = _dataService.IncomeController.GetIncomeById(income.Id);

            Assert.Null(incomeFromDb);
        }

        [Fact]
        public void CreateAndUpdate()
        {
            IIncome income = new Income("CreateAndUpdate", 28, DateTime.Now, "CategoryPlaceholder");
            income = _dataService.IncomeController.CreateIncome(income);

            Assert.Equal("CreateAndUpdate", income.Description);
            Assert.Equal(28, income.Amount);
            Assert.Equal("CategoryPlaceholder", income.Category);

            income.Description = "CreateAndUpdateUpdated";
            income.Amount = 100;
            income.Category = "CategoryPlaceholderUpdated";
            _dataService.IncomeController.UpdateIncome(income);

            IIncome incomeFromDb = _dataService.IncomeController.GetIncomeById(income.Id);

            Assert.Equal("CreateAndUpdateUpdated", incomeFromDb.Description);
            Assert.Equal(100, incomeFromDb.Amount);
            Assert.Equal("CategoryPlaceholderUpdated", incomeFromDb.Category);
        }

        [Fact]
        public void Delete()
        {
            IIncome income = new Income("Delete", 28, DateTime.Now, "CategoryPlaceholder");
            income = _dataService.IncomeController.CreateIncome(income);

            Assert.Equal("Delete", income.Description);
            Assert.Equal(28, income.Amount);
            Assert.Equal("CategoryPlaceholder", income.Category);

            _dataService.IncomeController.DeleteIncome(income.Id);
            IIncome incomeFromDb = _dataService.IncomeController.GetIncomeById(income.Id);

            Assert.Null(incomeFromDb);
        }

        [Fact]
        public void Retrieve()
        {
            var incomes = _dataService.IncomeController.GetIncomeAll();
            Assert.NotEmpty(incomes);
        }

        [Fact]
        public void RetrieveBetweenDate()
        {
            IIncome income = new Income("Delete", 28, DateTime.Now.AddDays(-2), "CategoryPlaceholder");
            income = _dataService.IncomeController.CreateIncome(income);

            IIncome income1 = new Income("Delete", 28, DateTime.Now.AddDays(-1), "CategoryPlaceholder");
            income1 = _dataService.IncomeController.CreateIncome(income1);

            var incomes = _dataService.IncomeController.GetIncomeBetweenDate(DateTime.Now.AddDays(-3), DateTime.Now.AddDays(-1));
            Assert.NotEmpty(incomes);
        }

        [Fact]
        public void RetrieveById()
        {
            IIncome income = new Income("Delete", 28, DateTime.Now.AddDays(-2), "CategoryPlaceholder");
            income = _dataService.IncomeController.CreateIncome(income);

            var incomes = _dataService.IncomeController.GetIncomeById(income.Id);
            Assert.NotNull(incomes);
        }
    }
}
