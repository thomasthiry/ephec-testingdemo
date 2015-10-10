﻿using System;
using System.ComponentModel.DataAnnotations;

namespace TestingDemo.Infrastructure.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        [Required]
        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Birth date")]
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }
    }
}