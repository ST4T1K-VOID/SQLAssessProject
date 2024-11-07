using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using MySqlConnection connection = new MySqlConnection(conString);
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
        public void DatabaseDeleteEmployee(Employee employee)
        {
            using MySqlConnection connection = new MySqlConnection(connString);

            string sqlQuery = @"DELETE FROM employees WHERE employee_id = @target_id";
            MySqlCommand command = new MySqlCommand(sqlQuery, connection);

            command.Parameters.AddWithValue("@target_id", employee.ID);

            connection.Open();

            command.ExecuteNonQuery();
        }
        public void DatabaseUpdateEmployee()
        {

        }
        public void DatabaseFilter(string filter, Tuple<string,string,string>? parameters)
        {
            /*
             * filter options
             * 
             * by name (firstname, lastname)
             * by salary (range, operator)
             * by branchid (id)
            */
        }
    }
}
