using Microsoft.VisualBasic;
using Org.BouncyCastle.Asn1.X509;
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
            AddEmployee("Jane", "Jane", 100, 2);
            AddEmployee("Smelly", "SR", 100000000, 1, 1);
            AddEmployee("Bob", "T Builder", 70200, 1, 1);
            AddEmployee("Poopy", "Joe", 1, 0, 1);
        }   

        public List<Employee> GetEmployees()
        {
            List<Employee> employeesList = employees;
            return employeesList;
        }

        public List<Employee> FindEmployees()
        {
            return employees;
        }

        public bool AddEmployee(string firstName, string lastName, DateOnly dateOfBirth, int grossSalary, int branchID, int supervisorID = 0)
        {
            int employeeID = (employees.Count + 1);

            foreach (Employee employee in employees)
            {
                if ((employee.FirstName == firstName) && (employee.LastName == lastName))
                {
                    return false;
                }
            }
            employees.Add(new Employee(employeeID, firstName, lastName, dateOfBirth, grossSalary, branchID, supervisorID));
            return true;
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

        public void UpdateEmployee(Employee targetEmployee, Employee updatedInfoEmployee)
        {
            
        }

        
    }
}
