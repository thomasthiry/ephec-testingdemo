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
            var employee = new Employee { Salary = 1000m };

            // Act
            var cost = employee.MonthlyCost;

            // Assert
            Assert.AreEqual(1408.33m, cost);
        }

        [TestMethod]
        public void MonthlyCost_OnlyMealVouchers_ReturnsSumForMonth()
        {
            // Arrange
            var employee = new Employee { HasMealVouchers = true };

            // Act
            var cost = employee.MonthlyCost;

            // Assert
            Assert.AreEqual(147m, cost);
        }

        [TestMethod]
        public void MonthlyCost_FullPackage_ReturnsFullTotal()
        {
            // Arrange
            var employee = new Employee { Salary = 1000m, CellphoneMonthlyAmount = 50m, GroupInsuranceMonthlyAmount = 30m, HealthInsuranceMonthlyAmount = 50m, HasMealVouchers = true };

            // Act
            var cost = employee.MonthlyCost;

            // Assert
            Assert.AreEqual(1635.33m, cost);
        }

        [TestMethod]
        public void MonthlyCost_NoPackage_ReturnsZero()
        {
            // Arrange
            var employee = new Employee();

            // Act
            var cost = employee.MonthlyCost;

            // Assert
            Assert.AreEqual(0m, cost);
        }

        [TestMethod]
        public void MonthlyCost_IncludesHolidayBonus_ReturnsSalaryAndBonus()
        {
            // Arrange
            var employee = new Employee { Salary = 1000m };

            // Act
            var cost = employee.MonthlyCost;

            // Assert
            Assert.AreEqual(1408.33m, cost);
        }
    }
}
