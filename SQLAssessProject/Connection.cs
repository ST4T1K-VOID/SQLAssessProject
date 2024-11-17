using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLproject
{
    public class Connection
    {
        private string connString = "server=localhost;user=root;database=mjo_ictprg431"; //TODO Change user

        /// <summary>
        /// Connects with the database to retrieve employee records
        /// </summary>
        /// <returns></returns>
        public List<Employee> DatabaseGetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            using MySqlConnection connection = new MySqlConnection(connString);

            string sqlQuery = "select * from employees";
            MySqlCommand command = new MySqlCommand(sqlQuery, connection);

            connection.Open();

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["employee_id"]);
                string firstName = reader.GetString("given_name");
                string lastName = reader.GetString("family_name");

                DateTime dateTime = reader.GetDateTime("date_of_birth");
                DateOnly dateOfBirth = DateOnly.FromDateTime(dateTime);

                string genderString = reader.GetString("gender_identity");
                GenderEnum gender = Enum.Parse<GenderEnum>(genderString);

                int salary = Convert.ToInt32(reader["gross_salary"]);
                int supervisorID = Convert.ToInt32(reader["supervisor_id"]);
                int branchID = Convert.ToInt32(reader["branch_id"]);

                Employee employee = new Employee(id, firstName, lastName, gender, dateOfBirth, salary, branchID, supervisorID);
                employees.Add(employee);
            }
            return employees;
        }
        /// <summary>
        /// Connects with database to add an employee record
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public int DatabaseAddEmployee(Employee employee)
        {
            using MySqlConnection connection = new MySqlConnection(connString);
            
            string sqlQuery = @"INSERT INTO employees(given_name, family_name, date_of_birth, gender_identity, gross_salary, supervisor_id, branch_id) 
                                VALUES(@given, @family, @dob, @gender, @salary, @supervisorid, @branchid);
                                SELECT LAST_INSERT_ID();";
            MySqlCommand command = new MySqlCommand(sqlQuery, connection);

            command.Parameters.AddWithValue("@given", employee.FirstName);
            command.Parameters.AddWithValue("@family", employee.LastName);
            command.Parameters.AddWithValue("@dob", employee.DateOfBirth.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@gender", employee.Gender);
            command.Parameters.AddWithValue("@salary", employee.GrossSalary);
            command.Parameters.AddWithValue("@supervisorid", employee.SupervisorID);
            command.Parameters.AddWithValue("@branchid", employee.BranchID);

            connection.Open();

            int returnID = Convert.ToInt32(command.ExecuteScalar());
            return returnID;
        }
        /// <summary>
        /// Connects with database to delete an employee record
        /// </summary>
        /// <param name="employee"></param>
        public void DatabaseDeleteEmployee(Employee employee)
        {
            using MySqlConnection connection = new MySqlConnection(connString);

            string sqlQuery = @"DELETE FROM employees WHERE employee_id = @target_id";
            MySqlCommand command = new MySqlCommand(sqlQuery, connection);

            command.Parameters.AddWithValue("@target_id", employee.ID);

            connection.Open();

            command.ExecuteNonQuery();
        }
        /// <summary>
        /// Connects with database to update an employee
        /// </summary>
        public void DatabaseUpdateEmployee(Employee employee)
        {
            using MySqlConnection connection = new MySqlConnection(connString);

            string sqlQuery = @"UPDATE employees
                                SET given_name = @new_given_name, family_name = @new_family_name, gender_identity = @new_gender,
                                gross_salary = @new_salary, branch_id = @new_bid, supervisor_id = @new_sid 
                                WHERE employee_id = @target_id";
            MySqlCommand command = new MySqlCommand(sqlQuery, connection);

            command.Parameters.AddWithValue("@target_id", employee.ID);
            command.Parameters.AddWithValue("@new_given_name", employee.FirstName);
            command.Parameters.AddWithValue("@new_family_name", employee.LastName);
            command.Parameters.AddWithValue("@new_gender", employee.Gender);
            command.Parameters.AddWithValue("@new_salary", employee.GrossSalary);
            command.Parameters.AddWithValue("@new_bid", employee.BranchID);
            command.Parameters.AddWithValue("@new_sid", employee.SupervisorID);

            connection.Open();

            command.ExecuteNonQuery();
        }
        /// <summary>
        /// Takes up to two strings and returns names from the database that match the input <br/>
        /// Can give a first name, last name or both
        /// </summary>
        /// <param name="targetFirstName"></param>
        /// <param name="targetLastName"></param>
        /// <returns></returns>
        public List<Employee>? DatabaseFilterByName(string targetFirstName, string targetLastName)
        {
            using MySqlConnection connection = new MySqlConnection(connString);
            if (targetFirstName == string.Empty && targetLastName != string.Empty)
            {
                string sqlQuery = @"SELECT * FROM employees WHERE family_name = @target_family_name";
                MySqlCommand command = new MySqlCommand(sqlQuery, connection);

                command.Parameters.AddWithValue("@target_family_name", targetLastName);
                List<Employee> employees = new List<Employee>();
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["employee_id"]);
                    string firstName = reader.GetString("given_name");
                    string lastName = reader.GetString("family_name");

                    DateTime dateTime = reader.GetDateTime("date_of_birth");
                    DateOnly dateOfBirth = DateOnly.FromDateTime(dateTime);

                    string genderString = reader.GetString("gender_identity");
                    GenderEnum gender = Enum.Parse<GenderEnum>(genderString);

                    int salary = Convert.ToInt32(reader["gross_salary"]);
                    int supervisorID = Convert.ToInt32(reader["supervisor_id"]);
                    int branchID = Convert.ToInt32(reader["branch_id"]);

                    Employee employee = new Employee(id, firstName, lastName, gender, dateOfBirth, salary, branchID, supervisorID);
                    employees.Add(employee);
                }
                return employees;
            }

            else if (targetFirstName != string.Empty && targetLastName == string.Empty)
            {
                string sqlQuery = @"SELECT * FROM employees WHERE given_name = @target_given_name";
                MySqlCommand command = new MySqlCommand(sqlQuery, connection);

                command.Parameters.AddWithValue("@target_given_name", targetFirstName);
                List<Employee> employees = new List<Employee>();
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["employee_id"]);
                    string firstName = reader.GetString("given_name");
                    string lastName = reader.GetString("family_name");

                    DateTime dateTime = reader.GetDateTime("date_of_birth");
                    DateOnly dateOfBirth = DateOnly.FromDateTime(dateTime);

                    string genderString = reader.GetString("gender_identity");
                    GenderEnum gender = Enum.Parse<GenderEnum>(genderString);

                    int salary = Convert.ToInt32(reader["gross_salary"]);
                    int supervisorID = Convert.ToInt32(reader["supervisor_id"]);
                    int branchID = Convert.ToInt32(reader["branch_id"]);

                    Employee employee = new Employee(id, firstName, lastName, gender, dateOfBirth, salary, branchID, supervisorID);
                    employees.Add(employee);
                }
                return employees;
            }

            else // firstname != null && lastname != null
            {
                string sqlQuery = @"SELECT * FROM employees WHERE given_name = @target_given_name AND family_name = @target_family_name";
                MySqlCommand command = new MySqlCommand(sqlQuery, connection);

                command.Parameters.AddWithValue("@target_family_name", targetLastName);
                command.Parameters.AddWithValue("@target_given_name", targetFirstName);

                List<Employee> employees = new List<Employee>();
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["employee_id"]);
                    string firstName = reader.GetString("given_name");
                    string lastName = reader.GetString("family_name");

                    DateTime dateTime = reader.GetDateTime("date_of_birth");
                    DateOnly dateOfBirth = DateOnly.FromDateTime(dateTime);

                    string genderString = reader.GetString("gender_identity");
                    GenderEnum gender = Enum.Parse<GenderEnum>(genderString);

                    int salary = Convert.ToInt32(reader["gross_salary"]);
                    int supervisorID = Convert.ToInt32(reader["supervisor_id"]);
                    int branchID = Convert.ToInt32(reader["branch_id"]);

                    Employee employee = new Employee(id, firstName, lastName, gender, dateOfBirth, salary, branchID, supervisorID);
                    employees.Add(employee);
                }
                return employees;
            }
        }
        /// <summary>
        /// returns employees from the database with a salary within the specified range
        /// </summary>
        /// <param name="max"></param>
        /// <param name="min"></param>
        public List<Employee>  DatabaseFilterBySalary(int max, int min)
        {
            using MySqlConnection connection = new MySqlConnection(connString);

            string sqlQuery = @"SELECT * FROM employees WHERE gross_salary < @max_range AND gross_salary > @min_range";
            MySqlCommand command = new MySqlCommand(sqlQuery, connection);

            command.Parameters.AddWithValue("@max_range", max);
            command.Parameters.AddWithValue ("@min_range", min);

            List<Employee> employeesBySalary = new List<Employee>();
            connection.Open();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["employee_id"]);
                string firstName = reader.GetString("given_name");
                string lastName = reader.GetString("family_name");

                DateTime dateTime = reader.GetDateTime("date_of_birth");
                DateOnly dateOfBirth = DateOnly.FromDateTime(dateTime);

                string genderString = reader.GetString("gender_identity");
                GenderEnum gender = Enum.Parse<GenderEnum>(genderString);

                int salary = Convert.ToInt32(reader["gross_salary"]);
                int supervisorID = Convert.ToInt32(reader["supervisor_id"]);
                int branchID = Convert.ToInt32(reader["branch_id"]);

                Employee employee = new Employee(id, firstName, lastName, gender, dateOfBirth, salary, branchID, supervisorID);
                employeesBySalary.Add(employee);
            }
            return employeesBySalary;
        }
        public List<Employee> DatabaseFilterByBranch(int targetBranchID)
        {
            using MySqlConnection connection = new MySqlConnection(connString);

            string sqlQuery = @"SELECT * FROM employees WHERE branch_id = @target_branch_id";

            MySqlCommand command = new MySqlCommand(sqlQuery, connection);
            command.Parameters.AddWithValue("@target_branch_id", targetBranchID);

            List<Employee> employees = new List<Employee>();
            connection.Open();

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["employee_id"]);
                string firstName = reader.GetString("given_name");
                string lastName = reader.GetString("family_name");

                DateTime dateTime = reader.GetDateTime("date_of_birth");
                DateOnly dateOfBirth = DateOnly.FromDateTime(dateTime);

                string genderString = reader.GetString("gender_identity");
                GenderEnum gender = Enum.Parse<GenderEnum>(genderString);

                int salary = Convert.ToInt32(reader["gross_salary"]);
                int supervisorID = Convert.ToInt32(reader["supervisor_id"]);
                int branchID = Convert.ToInt32(reader["branch_id"]);

                Employee employee = new Employee(id, firstName, lastName, gender, dateOfBirth, salary, branchID, supervisorID);
                employees.Add(employee);
            }
            return employees;
        }
        /// <summary>
        /// returns the total sales of the selected employee ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string? DatabaseFindEmployeeSales(int id)
        {
            using MySqlConnection connection = new MySqlConnection(connString);

            string sqlQuery = @"SELECT SUM(total_sales) FROM employees
                                INNER JOIN working_with
                                ON employees.employee_id = working_with.employee_id
                                WHERE employees.employee_id = @target_id";

            MySqlCommand command = new MySqlCommand(sqlQuery, connection);
            command.Parameters.AddWithValue("@target_id", id);

            connection.Open();
            string? result = Convert.ToString(command.ExecuteScalar());

            if (result == string.Empty)
            {
                return null;
            }

            return ("$" + result +" In Sales");
        }
    }
}
