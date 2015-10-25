using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestingDemo.AcceptanceTests.Pages
{
    public class PageObject
    {
        protected IWebDriver _driver;
        protected string BaseUrl = "http://localhost:60284";

        public PageObject(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(_driver, this);

        }
    }
}
