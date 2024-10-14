using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLproject
{
    internal class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GrossSalary { get; set; }
        public int  BranchID { get; set; }

        public Employee(int iD, string firstName, string lastName, int grossSalary, int branchID)
        {
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
            GrossSalary = grossSalary;
            BranchID = branchID;
        }
    }
}
