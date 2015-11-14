using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        [FindsBy(How = How.Id, Using = "employee_list")]
        public IWebElement EmployeeListTable { get; set; }

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

        public int NumberOfRows => EmployeeRows.Count;

        private ReadOnlyCollection<IWebElement> EmployeeRows => EmployeeListTable.FindElements(By.TagName("tr"));

        public int IndexOf(string lastName)
        {
            int cpt = 0;
            foreach (var employeeRow in EmployeeRows)
            {
                var tds = employeeRow.FindElements(By.TagName("td"));
                if (tds.Count == 0)
                {
                    continue;
                }

                var rowLastNameText = tds.First().Text;
                if (rowLastNameText == lastName)
                {
                    return cpt;
                }
                cpt = cpt + 1;
            }
            return -1;
        }

        public EmployeeDetails EditEmployee(string lastName)
        {
            return EditEmployee(IndexOf(lastName));
        }

        public EmployeeDetails EditEmployee(int rowIndex)
        {
            var linkEdit = EmployeeRows[rowIndex].FindElements(By.ClassName("link_edit")).First();

            linkEdit.Click();

            return new EmployeeDetails(_driver);
        }
    }
}
