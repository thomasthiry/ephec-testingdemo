﻿using System;
using System.ComponentModel.DataAnnotations;

namespace TestingDemo.Infrastructure.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }
        public bool IsMarried { get; set; }
        public int NumberOfChildren { get; set; }
        public bool HasMealVouchers { get; set; }
        public decimal HealthInsuranceMonthlyAmount { get; set; }
        public decimal GroupInsuranceMonthlyAmount { get; set; }
        public decimal CellphoneMonthlyAmount { get; set; }


        // voiture de fonction
    }
}