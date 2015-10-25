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

        public void FillLastName(string lastName)
        {
            LastName.SendKeys(lastName);
        }

        public void FillFirstName(string firstName)
        {
            FirstName.SendKeys(firstName);
        }

        public void FillBirthDate(string birthDate)
        {
            BirthDate.SendKeys(birthDate);
        }

        public void SubmitForm()
        {
            CreateButton.Click();
        }
    }
}
