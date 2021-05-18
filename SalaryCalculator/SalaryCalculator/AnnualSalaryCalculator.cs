using System;
namespace AnnualSalaryCalculator
{
    public class SalaryCalculator
    {
        public decimal GetAnualSalary(decimal hourlyWage)
        {
            const int HoursInYear = 2080;
            decimal annualSalary = hourlyWage * HoursInYear;
            Console.WriteLine($"The annual salary is: {annualSalary}");
            return annualSalary;
        }

        public decimal GetHourlyWage(decimal annualSalary)
        {
            const int HoursInYear = 2080;
            decimal hourlyWage = annualSalary / HoursInYear;
            Console.WriteLine($"The hourly wage is: {hourlyWage}");
            return hourlyWage;
        }
    }
}
