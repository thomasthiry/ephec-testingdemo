using System;

namespace TestingDemo.Domain
{
    public class Employee
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }

        public decimal YearlyCost
        {
            get { return Salary*12; }
        }
    }
}