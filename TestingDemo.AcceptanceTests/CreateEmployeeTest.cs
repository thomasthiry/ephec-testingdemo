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
    public class CreateEmployeeTest
    {
        [TestMethod]
        public void CreateAnEmployee()
        {
            using (IWebDriver wdriver = new ChromeDriver())
            {
                var employeeList = new EmployeeList(wdriver).GoTo();

                var employeeCreation = employeeList.ClickOnCreate();

                employeeCreation.FillLastName("Smith");
                employeeCreation.FillFirstName("John");
                employeeCreation.FillBirthDate("01/03/1996");

                employeeCreation.SubmitForm();

                Thread.Sleep(5000);

                //Assert.AreEqual(wdriver.Url, "http://www.threenine.co.uk/customer/account/login/");
                wdriver.Quit();
            }
        }
    }
}
