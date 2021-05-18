using HouseholdEconomy.Controllers;
using HouseholdEconomyTests.Seeder;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HouseholdEconomy.Tests
{

    [TestClass()]
    public class CalculatorTests
    {
        Calculator calc;
        EconomicController ecoController;
        TestSeeder testSeeder;

        [TestInitialize]
        public void Setup()
        {
            testSeeder = new TestSeeder();

        }

        [TestMethod()]
        public void GetTotalIncomeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetTotalExpenses_Pass_ShouldReturnSum_3599()
        {
            testSeeder.InitList();
            calc = new Calculator(testSeeder.ecoController.GetList);

            var expected = 3599;
            var actual = calc.GetTotalExpenses();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetTotalExpensesTest_Fail_Should()
        {
            testSeeder.InitList();
            testSeeder.ecoController.UpdateEconomicObjectAmount("Food", 999999);
            calc = new Calculator(testSeeder.ecoController.GetList);

            var expected = 3599;
            var actual = calc.GetTotalExpenses();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetTotalSavingTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetRemainingBalanceTest()
        {
            Assert.Fail();
        }
    }
}