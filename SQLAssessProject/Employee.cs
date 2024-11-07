using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLproject
{
    public class Employee
    {
        public int? ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GenderEnum Gender { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public int GrossSalary { get; set; }
        public int BranchID { get; set; }
        public int SupervisorID { get; set; } = 0;
        public DateTime DateCreated { get; set; } = DateTime.Now;

        public Employee(string firstName, string lastName, GenderEnum gender, DateOnly dateOfBirth, int salary, int branchID, int supervisorID)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            GrossSalary = salary;
            BranchID = branchID;
            SupervisorID = supervisorID;
        }
        public Employee(int id, string firstName, string lastName, GenderEnum gender, DateOnly dateOfBirth, int salary, int branchID, int supervisorID)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            GrossSalary = salary;
            BranchID = branchID;
            SupervisorID = supervisorID;

        }
        public override string ToString()
        {

            string stringID = ID.ToString();
            string birthString = DateOfBirth.ToString("yyyy/MM/dd");
            string stringSalary = GrossSalary.ToString();
            string gender;
            if (Gender == GenderEnum.M)
            {
                gender = "Male";
            }
            else if (Gender == GenderEnum.F)
            {
                gender = "Female";
            }
            else
            {
                gender = "Other";
            }

            return $"{stringID} {FirstName} {LastName} | {gender} | {birthString} | ${stringSalary}";
        }
    }
    public enum GenderEnum
    {
        M = 0,
        F = 1,
        O = 2
    }
    
}
