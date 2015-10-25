using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestingDemo.AcceptanceTests.Pages
{
    public class EmployeeList : PageObject
    {
        [FindsBy(How = How.Id, Using = "create_new")]
        public IWebElement CreateNewButton { get; set; }

        public EmployeeList(IWebDriver driver) : base(driver)
        {

        }

        public EmployeeList GoTo()
        {
            _driver.Navigate().GoToUrl(BaseUrl + "/Employees");
            _driver.Manage().Window.Maximize();

            return this;
        }

        public EmployeeDetails ClickOnCreate()
        {
            CreateNewButton.Click();
            return new EmployeeDetails(_driver);
        }
    }
}
