using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using TestingDemo.AcceptanceTests.Pages;

namespace TestingDemo.AcceptanceTests
{
    [TestClass]
    public class ManageEmployeeTest
    {
        [TestMethod]
        public void CreateEmployee()
        {
            // Arrange
            var driver = new ChromeDriver();
            var employeeList = new EmployeeList(driver).GoTo();
            var nbEmployeesInitial = employeeList.NumberOfRows;

            Thread.Sleep(3000);

            // Act
            var employeeDetails = employeeList.ClickOnCreate();

            Thread.Sleep(2000);

            employeeDetails.FillForm("McLane", "John", "10/12/1980");
            Thread.Sleep(2000);

            // Assert
            var nbEmployeesFinal = employeeList.NumberOfRows;

            Assert.AreEqual(nbEmployeesInitial + 1, nbEmployeesFinal);
            driver.Dispose();
        }
    }
}
