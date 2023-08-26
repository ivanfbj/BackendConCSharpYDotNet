namespace OpenClose
{
    public class EmployeeFullTime : Employee
    {

        public EmployeeFullTime(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        public override decimal CalculateSalaryMonthly()
        {
            decimal hourValue = 30000M;
            // EmployeeFullTime employeeFullTime = ((EmployeeFullTime)employee);
            // decimal salary = hourValue * employeeFullTime.HoursWorked;
            // Console.WriteLine($"Empleado: {employeeFullTime.Fullname}, Pago: {salary:C1} ");
            decimal salary = hourValue * HoursWorked;
            return salary;
        }

    }
}
