using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TestingDemo.DAL.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Birth date")]
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }
    }
}