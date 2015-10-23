using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace TestingDemo.Domain.SpecTests.Steps
{
    [Binding]
    public class MonthlyCostSteps
    {
        private Employee _employee;
        private decimal _cost;

        [Given(@"I have an employee with a salary of (.*) euros")]
        public void GivenIHaveAnEmployeeWithASalaryOfEuros(decimal salary)
        {
            _employee = new Employee { Salary = salary };
        }
        
        [When(@"I view his cost")]
        public void WhenIViewHisCost()
        {
            _cost = _employee.MonthlyCost;
        }
        
        [Then(@"the cost is (.*) euros")]
        public void ThenTheCostIsEuros(decimal expectedCost)
        {
            Assert.AreEqual(expectedCost, _cost);
        }
    }
}
