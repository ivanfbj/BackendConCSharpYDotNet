using OpenClose;

ShowSalaryMonthly(
    // new List<object>()
    new List<Employee>()
    {
        new EmployeeFullTime("Pepito Pérez", 160),
        new EmployeePartTime("Manuel Lopera", 180),
        new EmployeeContractor("Manuel Perez", 200)
    }
);

// void CalculateSalaryMonthly(List<object> employees)
void ShowSalaryMonthly(List<Employee> employees)
{
    foreach (var employee in employees)
    {
        Console.WriteLine(
            $"Empleado: {employee.Fullname}, Pago: {employee.CalculateSalaryMonthly():C1} "
        );
        // if (employee is EmployeeFullTime)
        // {
        //     decimal hourValue = 30000M;
        //     EmployeeFullTime employeeFullTime = ((EmployeeFullTime)employee);
        //     decimal salary = hourValue * employeeFullTime.HoursWorked;
        //     Console.WriteLine($"Empleado: {employeeFullTime.Fullname}, Pago: {salary:C1} ");
        // }
        // else
        // {
        //     decimal hourValue = 20000M;
        //     EmployeePartTime employeePartTime = ((EmployeePartTime)employee);
        //     decimal salary = hourValue * employeePartTime.HoursWorked;
        //     if (employeePartTime.HoursWorked > 160) {
        //         decimal effortCompensation = 5000M;
        //         int extraDays = employeePartTime.HoursWorked - 160;
        //         salary += effortCompensation * extraDays;
        //     }
        //     Console.WriteLine($"Empleado: {employeePartTime.Fullname}, Pago: {salary:C1} ");
        // }
    }
}
