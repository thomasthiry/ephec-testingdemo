using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestingDemo.AcceptanceTests.Pages
{
    public class EmployeeDetails : PageObject
    {
        [FindsBy(How = How.Id, Using = "LastName")]
        private IWebElement LastName { get; set; }
        [FindsBy(How = How.Id, Using = "FirstName")]
        private IWebElement FirstName { get; set; }
        [FindsBy(How = How.Id, Using = "BirthDate")]
        private IWebElement BirthDate { get; set; }
        [FindsBy(How = How.CssSelector, Using = "input[type=submit]")]
        private IWebElement CreateButton { get; set; }

        public EmployeeDetails(IWebDriver driver) : base(driver)
        {

        }

        public EmployeeDetails GoTo()
        {
            _driver.Navigate().GoToUrl(BaseUrl + "/Employees/Create");
            _driver.Manage().Window.Maximize();

            return this;
        }

        public EmployeeList FillForm(string lastName, string firstName, string birthDate)
        {
            LastName.SendKeys(lastName);
            FirstName.SendKeys(firstName);
            BirthDate.SendKeys(birthDate);

            CreateButton.Click();

            return new EmployeeList(_driver);
        }
    }
}
