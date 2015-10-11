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
        [DataType(DataType.Date)]
        [Required]
        public DateTime BirthDate { get; set; }

        public decimal Salary { get; set; }

        [Display(Name = "Is Married")]
        public bool IsMarried { get; set; }

        [Display(Name = "Number Of Children")]
        public int NumberOfChildren { get; set; }

        [Display(Name = "Has Meal Vouchers")]
        public bool HasMealVouchers { get; set; }

        [Display(Name = "Health Insurance")]
        public decimal HealthInsuranceMonthlyAmount { get; set; }

        [Display(Name = "Group Insurance")]
        public decimal GroupInsuranceMonthlyAmount { get; set; }

        [Display(Name = "Cellphone Amount")]
        public decimal CellphoneMonthlyAmount { get; set; }

        [Display(Name = "Yearly Cost")]
        public decimal YearlyCost { get; set; }
    }
}