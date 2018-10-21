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

        public bool IsMarried { get; set; }

        public int NumberOfChildren { get; set; }

        public bool HasMealVouchers { get; set; }

        public decimal HealthInsuranceMonthlyAmount { get; set; }

        public decimal GroupInsuranceMonthlyAmount { get; set; }

        public decimal CellphoneMonthlyAmount { get; set; }

        public decimal MonthlyCost
        {
            get
            {
                decimal mealVoucherMonthlyAmount = 0;
                if (HasMealVouchers)
                {
                    mealVoucherMonthlyAmount = 21 * 7m;
                }

                var employerContributionRate = 1.3m;

                var monthlyCost = Salary * employerContributionRate
                                  + mealVoucherMonthlyAmount
                                  + GroupInsuranceMonthlyAmount
                                  + CellphoneMonthlyAmount;

                return Decimal.Round(monthlyCost, 2);
            }
        }
    }
}