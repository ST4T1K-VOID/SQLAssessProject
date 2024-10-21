using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLproject
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GenderEnum Gender { get; set; }
        public DateOnly DateOfBirth { get; set; }

        public DateTime DateCreated = DateTime.Now;
        public int GrossSalary { get; set; }
        public int BranchID { get; set; }
        public int SupervisorID { get; set; } = 0;
        
        public Employee(int employeeID, string firstName, string lastName, GenderEnum gender, DateOnly dateOfBirth, int grossSalary, int branchID, int supervisorID)
        {
            ID = employeeID;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            GrossSalary = grossSalary;
            SupervisorID = supervisorID;
            BranchID = branchID;
        }

        public override string ToString()
        {

            string stringID = ID.ToString();
            string birthString = DateOfBirth.ToString("yyyy/mm/dd");
            string stringSalary = GrossSalary.ToString();

            return $"{stringID} {FirstName}{LastName} {Gender} | {birthString} | {stringSalary}";
        }
    }
    public enum GenderEnum
    {
        Male = 'M',
        Female = 'F',
        Other = 'O'
    }
}
