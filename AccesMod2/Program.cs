using System;
using Classes;
namespace AccesMod2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "Rovshen";
            employee.Surname = "Memmedov";
            employee.Salary = 5000;

            Employee employee1 = new Employee();
            employee1.Name = "Rena";
            employee1.Surname = "Ekberov";
            employee1.Salary = 2000;

            Employee employee2 = new Employee();
            employee2.Name = "Emine";
            employee2.Surname = "Omerova";
            employee2.Salary = 200;

            Department department = new Department();
            
            department.EmployeeLimit = 3;
            department.AddEmployee(employee);
            department.AddEmployee(employee1);
            department.AddEmployee(employee2);

            foreach (var item in department.Employees)
            {
                Console.WriteLine(item.Name + " " + item.Surname + " " + item.Salary);
            }

        }
    }
}
