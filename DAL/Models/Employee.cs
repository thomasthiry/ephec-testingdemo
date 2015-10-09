using System;
using System.ComponentModel.DataAnnotations;

namespace TestingDemo.DAL.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }
    }
}