﻿using Microsoft.VisualBasic;
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
        private Connection databaseConnection = new Connection();

        public DataService()
        {
            RefreshEmployees();
        }   
        private void RefreshEmployees()
        {
            employees = databaseConnection.DatabaseGetEmployees();
        }
        /// <summary>
        /// Returns list of employees
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetEmployees()
        {
            List<Employee> employeesList = employees.ToList();
            return employeesList;
        }
        /// <summary>
        /// Searches for employees with a specififed first or last name or both.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="Lastname"></param>
        /// <returns>
        /// List: of all employees matching the specified parameters.
        /// </returns>
        public List<Employee> FindEmployees(string? firstName = null, string? Lastname = null)
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
        /// <summary>
        /// Adds an employee
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="gender"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="grossSalary"></param>
        /// <param name="branchID"></param>
        /// <param name="supervisorID"></param>
        /// <returns>
        /// False: if an employee with the same first and last name is found <br/>
        /// True: if addition was successful
        /// </returns>
        public bool AddEmployee(string firstName, string lastName, GenderEnum gender, DateOnly dateOfBirth, int grossSalary, int branchID, int supervisorID)
        {
            Employee tempEmployee =  new Employee(firstName, lastName, gender, dateOfBirth, grossSalary, branchID, supervisorID);
            int employeeID = 0;

            try
            {
                employeeID = databaseConnection.DatabaseAddEmployee(tempEmployee);
            }
            catch
            {
                return false;
            }

            employees.Add(new Employee(employeeID, firstName, lastName, gender, dateOfBirth, grossSalary, branchID, supervisorID));
            return true;
        }
        /// <summary>
        /// Removes selected employee
        /// </summary>
        /// <param name="targetEmployee"></param>
        /// <returns>
        /// False: if targeted employee could not be found <br/>
        /// True: if removal was successful
        /// </returns>
        public bool RemoveEmployee(Employee targetEmployee)
        {
            try
            {
                databaseConnection.DatabaseDeleteEmployee(targetEmployee);
            }
            catch 
            {
                return false; 
            }

            RefreshEmployees();
            return true;
        }
        /// <summary>
        /// replaces selected employee with an updated version of selected employee.
        /// </summary>
        /// <param name="targetEmployee"></param>
        /// <param name="updatedInfoEmployee"></param>
        /// <returns>
        /// False: if targeted employee doesn't exist <br/>
        /// True: if updating was successful
        /// </returns>
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
