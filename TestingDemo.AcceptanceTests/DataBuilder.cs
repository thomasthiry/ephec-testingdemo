using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingDemo.Infrastructure;
using TestingDemo.Infrastructure.Models;

namespace TestingDemo.AcceptanceTests
{
    class DataBuilder
    {
        private TestingDemoContext dbContext = new TestingDemoContext();

        public void AddEmployeeInDb(string lastName, string firstname)
        {
            var employee = new Employee
            {
                FirstName = firstname,
                LastName = lastName,
                BirthDate = DateTime.Today.AddYears(-25)
            };

            dbContext.Employees.Add(employee);
            dbContext.SaveChanges();
        }
    }
}
