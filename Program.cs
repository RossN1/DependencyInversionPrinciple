using System;

namespace week7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create EmployeeDetails Class.
            var employeeDetails = new EmployeeDetails(new SalaryCalculatorModified());  
            Console.WriteLine("Enter hourly rate: ");
            employeeDetails.HourlyRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter hours worked: ");
            employeeDetails.HoursWorked = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine($"The Total Pay is {employeeDetails.GetSalary()}");  

        }
    }
}
