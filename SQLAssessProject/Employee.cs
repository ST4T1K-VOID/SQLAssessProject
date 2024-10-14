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
        public DateOnly DateOfBirth { get; set; }
        public int GrossSalary { get; set; }
        public int BranchID { get; set; }
        public int SupervisorID { get; set; } = 0;
        
        public Employee(int employeeID, string firstName, string lastName, DateOnly dateOfBirth, int grossSalary, int branchID, int supervisorID)
        {
            ID = employeeID;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            GrossSalary = grossSalary;
            SupervisorID = supervisorID;
            BranchID = branchID;
        }

        public override string ToString()
        {

            string stringID = ID.ToString();
            string firstName = FirstName;
            string lastName = LastName;
            string stringSalary = GrossSalary.ToString();
            string stringBranch = BranchID.ToString();
            string stringSupervisor = SupervisorID.ToString();

            return $"{firstName}  {lastName}  {stringID}  ${stringSalary}  {stringBranch}  {stringSupervisor}";
        }
    }
}
