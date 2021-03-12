using System;

namespace Employee
{
    public class Employee : EmployeeBase
    {
        internal decimal yearlySalary;
        internal decimal yearlySalaryRaise;
        private string firstname;
        private string lastname;
        private decimal monthlySalary;
        private decimal Employee1yearlySalary;
        private decimal Employee2yearlySalary;
        private decimal Employee1yearlySalaryRaise;
        private decimal Employee2yearlySalaryRaise;
        private decimal Employee1NewYearlySalary;
        private decimal Employee2NewYearlySalary;
        private string v1;
        private string v2;
        private string v3;

        public Employee(string v1, string v2, string v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }



        //eight paramter constructor
        public Employee(string first, string last, decimal Salary, decimal v0, decimal v1, decimal v2, decimal v3, decimal v4, decimal v5)
        {
            firstname = first;
            lastname = last;
            monthlySalary = Salary;
            Employee1yearlySalary = v0;
            Employee2yearlySalary = v1;
            Employee1yearlySalaryRaise = v2;
            Employee2yearlySalaryRaise = v3;
            Employee1NewYearlySalary = v4;
            Employee2NewYearlySalary = v5;
        }
        public string Firstname
        {
            get
            {
                return firstname;
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }
        }

        public decimal MonthlySalary
        {
            get
            {
                return monthlySalary;
            }
            set
            {
                if (value < 0)
                    monthlySalary = value;
            }
        }

        public decimal employee1yearlySalary
        {
            get
            {
                return Employee1yearlySalary;
            }
        }

        public decimal employee2yearlySalary
        {
            get
            {
                return Employee2yearlySalary;
            }
        }

        public decimal employee1yearlySalaryRaise
        {
            get
            {
                return Employee1yearlySalaryRaise;
            }
        }

        public decimal employee2yearlySalaryRaise
        {
            get
            {
                return Employee2yearlySalaryRaise;
            }
        }

        public decimal employee1NewYearlySalary
        {
            get
            {
                return Employee1NewYearlySalary;
            }
        }

        public decimal employee2NewYearlySalary
        {
            get
            {
                return Employee2NewYearlySalary;
            }
        }

        public decimal NewYearlySalary { get; internal set; }
    }


    public class EmployeeTest
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee("Scott", "Mcall", "50000.00M");

            Console.WriteLine("firstname is {0}:", employee.Firstname);
            Console.WriteLine("lastname is {1}:", employee.Lastname);
            Console.WriteLine("monthlySalary is {2}:", employee.MonthlySalary);

            Employee Employee1 = new employee1yearlySalary();

            Employee Employee2 = new employee2yearlySalary();

            Console.WriteLine("Employee1yearlySalary is {3}:", Employee1.employee1yearlySalary);
            Console.WriteLine("Employee2yearlySalary is {4}:", Employee2.employee2yearlySalary);

            Employee1.yearlySalary = 600000.00M;
            Employee2.yearlySalary = 600000.00M;
            _ = new yearlySalaryRaise();
            _ = new yearlySalaryRaise();

            Console.WriteLine("Employee1yearlySalaryRaise is {5}:", Employee1.employee1yearlySalaryRaise);
            Console.WriteLine("Employee2yearlySalaryRaise is {6}:", Employee2.employee2yearlySalaryRaise);

            Employee1.yearlySalaryRaise = 10 / 100 * Employee1.yearlySalary;
            Employee2.yearlySalaryRaise = 10 / 100 * Employee2.yearlySalary;
            _ = new NewYearlySalary();
            _ = new NewYearlySalary();

            Console.WriteLine("Employee1NewYearlySalary is {7}:", Employee1.employee1NewYearlySalary);
            Console.WriteLine("Employee2NewYearlySalary is {8}:", Employee2.employee2NewYearlySalary);

            Employee1.NewYearlySalary = Employee1.employee1yearlySalaryRaise + Employee1.employee1yearlySalary;
            Employee2.NewYearlySalary = Employee2.employee2yearlySalaryRaise + Employee2.employee2yearlySalary;
        }
    }
}
