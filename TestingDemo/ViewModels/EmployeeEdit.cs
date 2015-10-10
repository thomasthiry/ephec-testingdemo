using System;
using System.ComponentModel.DataAnnotations;

namespace TestingDemo.ViewModels
{
    public class EmployeeEdit
    {
        public int Id { get; set; }
        [Display(Name = "Last name")]
        [Required]
        public string LastName { get; set; }
        [Display(Name = "First name")]
        [Required]
        public string FirstName { get; set; }
        [Display(Name = "Birth date")]
        [Required]
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }
        public decimal YearlyCost { get; set; }
    }
}