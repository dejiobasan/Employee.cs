namespace Employee
{
    public class EmployeeBase
    {

        public override string Tostring => string.Format("{0}: {1}\n{2}: {3}\n{4}: {5}\n{6}: {7}\n{8}:", "employee", Firstname,
Lastname, "monthlySalary", MonthlySalary, "employee1yearlySalary", Employee1yearlySalary,
"employee2yearlySalary", Employee2yearlySalary, "employee1yearlySalaryRaise",
Employee1yearlySalaryRaise, "employee2yearlySalaryRaise", Employee2yearlySalaryRaise,
"employeeNewYearlySalary", Employee1NewYearlySalary, "employee2NewYearlySalary",
Employee2NewYearlySalary);
    }
}