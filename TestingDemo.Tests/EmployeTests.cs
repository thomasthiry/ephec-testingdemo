using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingDemo.Domain.Tests
{
    [TestClass]
    public class EmployeTests
    {
        [TestMethod]
        public void MonthlyCost_OnlySalary_ReturnsSalaryWithEmployerCotisations()
        {
            // Arrange
            var employee = new Employee { Salary = 1000 };

            // Act
            var cost = employee.MonthlyCost;

            // Assert
            Assert.AreEqual(1399.67m, cost);
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
            var employee = new Employee { Salary = 1000, HasMealVouchers = true, HealthInsuranceMonthlyAmount = 30m, CellphoneMonthlyAmount = 50m, GroupInsuranceMonthlyAmount = 35m };

            // Act
            var cost = employee.MonthlyCost;

            // Assert
            Assert.AreEqual(1661.67m, cost);
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
        public void MonthlyCost_Maried_HealthInsuranceIncludesPartnerFee()
        {
            // Arrange
            var employee = new Employee { HealthInsuranceMonthlyAmount = 30m, IsMarried = true };

            // Act
            var cost = employee.MonthlyCost;

            // Assert
            Assert.AreEqual(60m, cost);
        }

        [TestMethod]
        public void MonthlyCost_Family_HealthInsuranceIncludesFamilyFee()
        {
            // Arrange
            var employee = new Employee { HealthInsuranceMonthlyAmount = 30m, IsMarried = true, NumberOfChildren = 3 };

            // Act
            var cost = employee.MonthlyCost;

            // Assert
            Assert.AreEqual(105m, cost);
        }

        [TestMethod]
        public void YearlyCost_FullPackage_ReturnsTotalYearlyCost()
        {
            // Arrange
            var employee = new Employee { Salary = 1000, HasMealVouchers = true, HealthInsuranceMonthlyAmount = 30m, CellphoneMonthlyAmount = 50m, GroupInsuranceMonthlyAmount = 35m };

            // Act
            var cost = employee.YearlyCost;

            // Assert
            Assert.AreEqual(19940.04m, cost);
        }
    }
}
