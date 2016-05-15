using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingDemo.Domain.Tests
{
    [TestClass]
    public class EmployeTests
    {
        [TestMethod]
        public void MonthlyCost_OnlySalary_ReturnsSalaryWithEmployerContributions()
        {
            // Arrange
            var employee = new Employee { Salary = 1000 };

            // Act
            var cost = employee.MonthlyCost;

            // Assert
            Assert.AreEqual(1508, cost);
        }

        [TestMethod]
        public void MonthlyCost_OnlyMealVouchers_ReturnsSumForMonth()
        {
            // Arrange
            var employee = new Employee { HasMealVouchers = true };

            // Act
            var cost = employee.MonthlyCost;

            // Assert
            Assert.AreEqual(147, cost);
        }

        [TestMethod]
        public void MonthlyCost_FullPackage_ReturnsFullTotal()
        {
            // Arrange
            var employee = new Employee { Salary = 1000, CellphoneMonthlyAmount = 50, GroupInsuranceMonthlyAmount = 30, HasMealVouchers = true };

            // Act
            var cost = employee.MonthlyCost;

            // Assert
            Assert.AreEqual(1527, cost);
        }

        [TestMethod]
        public void MonthlyCost_NoPackage_ReturnsZero()
        {
            // Arrange
            var employee = new Employee();

            // Act
            var cost = employee.MonthlyCost;

            // Assert
            Assert.AreEqual(0, cost);
        }

        [TestMethod]
        public void YearlyCost_FullPackage_ReturnsYearlyCost()
        {
            // Arrange
            var employee = new Employee { Salary = 1000, CellphoneMonthlyAmount = 50, GroupInsuranceMonthlyAmount = 30, HasMealVouchers = true };

            // Act
            var cost = employee.YearlCost;

            // Assert
            Assert.AreEqual(20820, cost);
        }
    }
}
