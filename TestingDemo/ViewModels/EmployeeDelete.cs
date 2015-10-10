using System;
using System.ComponentModel.DataAnnotations;

namespace TestingDemo.ViewModels
{
    public class EmployeeDelete
    {
        public int Id { get; set; }
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        [Display(Name = "First name")]
        public string FirstName { get; set; }
    }
}