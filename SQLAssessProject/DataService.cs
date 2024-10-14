using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLproject
{
    class DataService
    {
        private List<Employee> employees = new List<Employee>();

        public DataService()
        {
            AddEmployee(101, "Jane", "Bane", 100, 2);
            AddEmployee(102, "Smelly", "SR", 100000000, 1);
            AddEmployee(103, "Bob", "Builer", 70200, 1);
            AddEmployee(104, "Poopy", "Joe", 1, 0);
            AddEmployee(105, "Rae", "Summers", 56000, 3);
        }

        public enum updateFilter
        {
            employeeID = 0,
            firstName = 1,
            lastName = 2,
            salary = 3,
            branchID = 4,
        }

        updateFilter filter = new updateFilter();

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public List<Employee> FindEmployees()
        {
            return employees;
        }

        public void AddEmployee(int employeeID, string firstName, string lastName, int grossSalary, int branchID)
        {
            employees.Add(new Employee(employeeID, firstName, lastName, grossSalary, branchID));
        }

        public bool RemoveEmployee(Employee targetEmployee)
        {
            foreach (Employee employee in employees)
            {
                if (employee.ID == targetEmployee.ID)
                {
                    employees.Remove(employee);
                    return true;
                }
            }
            return false;
        }

        //public void UpdateEmployee(updateFilter filter, Employee targetEmployee)
        //{
            




        //    int castFilter = (int)filter;

        //    switch (castFilter)
        //    {
        //        case 0:
        //            var newInfo = 
        //    }
        //}

        
    }
}
