using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeClass
{
    class Employee
    {
        public string name;
        public string position;
        public int id;
        public double salary;
        private readonly string skippy = "-----------------------------------------------";


        public Employee(string name, string position, int id, double salary)
        {
            this.name = name;
            this.position = position;
            this.id = id;
            this.salary = salary;
        }
        public Employee()
        {
            name = null;
            position = null;
            id = 0;
            salary = 0;
        }
        public void PrintEmployeeInfo()
        {
            Console.WriteLine("Employees basic information");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Position: {position} ");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Salary: {salary}");
            Console.WriteLine(skippy);
        }

        public void CompareSalary(Employee employee)
        {
            if(salary == employee.salary)
            {
                Console.WriteLine("Salaries are equal");
            }
            else if (salary < employee.salary)
            {
                Console.WriteLine($"{employee.name} has bigger paycheck than {name}");
            }
            else
            {
                Console.WriteLine($"{name} has bigger paycheck than {employee.name}");
            }
            Console.WriteLine(skippy);
        }
    }
}
