using System;
using System.Collections.Generic;
using TestingDemo.DAL.Models;

namespace TestingDemo.DAL
{
    public class DataInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<TestingDemoContext>
    {
        protected override void Seed(TestingDemoContext context)
        {
            var employees = new List<Employee>
            {
                new Employee { FirstName = "Sarah", LastName = "Connor", BirthDate = new DateTime(1980, 4, 18)},
                new Employee { FirstName = "Frodo", LastName = "Baggins", BirthDate = new DateTime(1951, 2, 1)},
                new Employee { FirstName = "Luke", LastName = "Skywalker", BirthDate = new DateTime(1967, 9, 6)}
            };

            employees.ForEach(e => context.Employees.Add(e));
            context.SaveChanges();
        }
    }
}