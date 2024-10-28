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
            connection.Open();

            string sqlQuery = "select * from employees";
            MySqlCommand command = new MySqlCommand(sqlQuery, connection);

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

        public void DatabaseAddEmployee()
        {

        }
        public void DatabaseDeleteEmployee()
        {

        }
        public void DatabaseUpdateEmployee()
        {

        }
    }
}
