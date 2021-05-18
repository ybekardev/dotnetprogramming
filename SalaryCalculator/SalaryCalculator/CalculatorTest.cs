using AnnualSalaryCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void AnnualSalary()
        {
            SalaryCalculator sc = new SalaryCalculator();
            decimal annualSalary = sc.GetAnualSalary(50);
            Assert.AreEqual(104000, annualSalary);
        }

        [TestMethod]
        public void HourlyWage()
        {
            SalaryCalculator sc = new SalaryCalculator();
            decimal hourlyWage = sc.GetHourlyWage(52000);
            Assert.AreEqual(25, hourlyWage);
        }
    }
}
