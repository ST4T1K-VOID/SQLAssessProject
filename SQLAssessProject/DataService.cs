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
    public class DataService
    {
        private List<Employee> employees = new List<Employee>();

        public DataService()
        {
        }   

        public List<Employee> GetEmployees()
        {
            List<Employee> employeesList = employees;
            return employeesList;
        }

        public List<Employee> FindEmployees(string firstName = null, string Lastname = null)
        {
            List<Employee> filteredEmployees = new List<Employee>();
            if (firstName == null && Lastname == null)
            {
                return employees;
            }
            else if (firstName != null && Lastname == null)
            {
                foreach (Employee employee in employees)
                {
                    if (employee.FirstName == firstName)
                    {
                        filteredEmployees.Add(employee);
                    }
                }
            }
            else if (firstName == null && Lastname != null)
            {
                foreach(Employee employee in employees)
                {
                    if (employee.LastName == Lastname)
                    {
                        filteredEmployees.Add(employee);
                    }
                }
            }
            else //firstname && lastname != Null
            {
                foreach (Employee employee in employees)
                {
                    if (employee.FirstName == firstName && employee.LastName == Lastname)
                    {
                        filteredEmployees.Add(employee);
                    }
                }
            }
            return filteredEmployees;
        }

        public bool AddEmployee(string firstName, string lastName, DateOnly dateOfBirth, int grossSalary, int branchID, int supervisorID = 0)
        {
            return false;
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

        public bool UpdateEmployee(Employee targetEmployee, Employee updatedInfoEmployee)
        {
            if (employees.Contains(targetEmployee) == false)
            {
                return false;
            }
            int index = employees.IndexOf(targetEmployee);
            employees[index] = updatedInfoEmployee;
            return true;
        }
    }
}
