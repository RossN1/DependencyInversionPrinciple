using System;

namespace week7
{
 // Create SalaryCalculator Interface
public interface ISalaryCalculator
    {
        float CalculateSalary(int hoursWorked, float hourlyRate);
    }

    // Implement the SalaryCalculator interface
    public class SalaryCalculatorModified : ISalaryCalculator 
    {
        public float CalculateSalary(int hoursWorked, float hourlyRate) => hoursWorked * hourlyRate;
    }


    // Depends upon the ISalaryCalculator Interface
    public class EmployeeDetails 
    {
        // Hidden from EmployeeDetails
        private readonly ISalaryCalculator _salaryCalculator;
        
        public int HoursWorked{get; set;}
        public int HourlyRate{get; set;}
        
        public EmployeeDetails(ISalaryCalculator salaryCalculator) 
        {
            _salaryCalculator = salaryCalculator;
        }
        public float GetSalary()
        {
            // Hidden from EmployeeDetails
            return _salaryCalculator.CalculateSalary(HoursWorked, HourlyRate);
        }
    }

}