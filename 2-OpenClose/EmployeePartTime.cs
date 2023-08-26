namespace OpenClose
{
    public class EmployeePartTime : Employee
    {
        public EmployeePartTime(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        public override decimal CalculateSalaryMonthly()
        {
            decimal hourValue = 20000M;
            // EmployeePartTime employeePartTime = ((EmployeePartTime)employee);
            // decimal salary = hourValue * employeePartTime.HoursWorked;
            decimal salary = hourValue * HoursWorked;
            // if (employeePartTime.HoursWorked > 160)
            if (HoursWorked > 160)
            {
                decimal effortCompensation = 5000M;
                // int extraDays = employeePartTime.HoursWorked - 160;
                int extraDays = HoursWorked - 160;
                salary += effortCompensation * extraDays;
            }
            // Console.WriteLine($"Empleado: {employeePartTime.Fullname}, Pago: {salary:C1} ");
            return salary;
        }
    }
}
