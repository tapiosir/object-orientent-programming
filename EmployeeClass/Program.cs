using System;
using System.Collections.Generic;
using System.Linq;


namespace EmployeeClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];
            employees[0] = new Employee("worker1", "pos1", 1, 1111);
            employees[1] = new Employee("worker2", "pos2", 2, 2222);
            employees[2] = new Employee("worker3", "pos3", 3, 3333);
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].PrintEmployeeInfo();
            }

            employees[0].CompareSalary(employees[1]);
            employees[1].CompareSalary(employees[2]);
            employees[2].CompareSalary(employees[0]); 
        }
    }
}
