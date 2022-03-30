using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
       public class Department
    {
        public Department()
        {
            this._employees = new Employee[0];
        }
        public string DepartmentName { get; set; }
      
        private int _employeeLimit;
        
        public int SalaryLimit; 

        private Employee[] _employees;
        public Employee[] Employees
        {
            get => _employees;
        }

        public int EmployeeLimit
        {
            get => _employeeLimit;
            set
            {
                _employeeLimit = value;
            }
        }

        //public int SalaryLimit
        //{
        //    get => _salaryLimit;
        //    set
        //    {
        //        if (value > 250)
        //        {
        //            _salaryLimit = value;
        //        }
        //    }
        //}

        public void AddEmployee(Employee employee)
        {
            if (EmployeeLimit >_employees.Length)
            {
                Array.Resize(ref _employees, _employees.Length + 1);
                _employees[_employees.Length - 1] = employee;
            }
        }
    }
}
