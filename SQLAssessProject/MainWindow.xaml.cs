using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SQLproject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataService Service = new DataService();
        public MainWindow()
        {
            InitializeComponent();
            ListEmployees();         
        }

        void ListEmployees()
        {
            list_employees.ItemsSource = null;
            list_employees.ItemsSource = Service.GetEmployees(); 
        }

        private void list_employees_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Employee? selectedEmployee = list_employees.SelectedItem as Employee;
            if (selectedEmployee == null)
            {
                return;
            }
            textbox_FirstName.Text = selectedEmployee.FirstName;
            textbox_LastName.Text = selectedEmployee.LastName;
            textbox_EmployeeID.Text = selectedEmployee.ID.ToString();
            textbox_Salary.Text = selectedEmployee.GrossSalary.ToString();
            textbox_BranchID.Text = selectedEmployee.BranchID.ToString();
            textbox_SupervisorID.Text = selectedEmployee.SupervisorID.ToString();
            textbox_dateOfBirth.Text = selectedEmployee.DateOfBirth.ToString();
            if (selectedEmployee.Gender == GenderEnum.M)
            {
                textbox_gender.Text = "Male";
            }
            else if (selectedEmployee.Gender == GenderEnum.F)
            {
                textbox_gender.Text = "Female";
            }
            else
            {
                textbox_gender.Text = "Other";
            }
        }
        private void button_refresh_Click(object sender, RoutedEventArgs e)
        {
            ListEmployees();
        }

        //CRUD Methods
        private void button_AddEmployee_Click(object sender, RoutedEventArgs e)
        {
            AddEmployeeWindow addEmployeeWindow = new AddEmployeeWindow();
            addEmployeeWindow.ShowDialog();
            if (addEmployeeWindow.DialogResult == true)
            {
                string tempFirstName = addEmployeeWindow.textbox_firstName.Text;
                string tempLastName = addEmployeeWindow.textbox_lastName.Text;
                int tempSalary = int.Parse(addEmployeeWindow.textbox_salary.Text);
                int tempBranchID = int.Parse(addEmployeeWindow.textbox_branchID.Text);
                int tempSupervisorID = int.Parse(addEmployeeWindow.textbox_supervisorID.Text);

                Service.AddEmployee(tempFirstName, tempLastName, (GenderEnum)addEmployeeWindow.combo_gender.SelectedItem, DateOnly.Parse(addEmployeeWindow.datepicker_dateOfBirth.Text), tempSalary, tempBranchID, tempSupervisorID);
                ListEmployees();
            }
        }

        private void button_UpdateEmployee_Click(object sender, RoutedEventArgs e)
        {
            if (list_employees.SelectedItem == null)
            {
                return;
            }
            Employee selectedEmployee = list_employees.SelectedItem as Employee;
            UpdateEmployeeWindow updateEmployeeWindow = new UpdateEmployeeWindow(list_employees.SelectedItem as Employee);
            updateEmployeeWindow.ShowDialog();
            if (updateEmployeeWindow.DialogResult == true)
            {
                Employee oldEmployee = list_employees.SelectedItem as Employee;
                string updatedFirstName = updateEmployeeWindow.textbox_firstName.Text;
                string updatedLastName = updateEmployeeWindow.textbox_lastName.Text;
                int updatedSalary = int.Parse(updateEmployeeWindow.textbox_salary.Text);
                int updatedBranchID = int.Parse(updateEmployeeWindow.textbox_branchID.Text);
                int updatedSupervisorID = int.Parse(updateEmployeeWindow.textbox_supervisorID.Text);
                GenderEnum tempgender = (GenderEnum)updateEmployeeWindow.combo_gender.SelectedIndex;

                Employee updatedEmployee = new Employee(updatedFirstName, updatedLastName, tempgender, oldEmployee.DateOfBirth, updatedSalary, updatedBranchID, updatedSupervisorID);
                if (Service.UpdateEmployee(oldEmployee, updatedEmployee))
                {
                    MessageBox.Show("Employee updated", "Successful Operation", MessageBoxButton.OK);
                    ListEmployees();
                }
                else
                {
                    MessageBox.Show("Employee under that name already exsists", "Unsuccessful Operation", MessageBoxButton.OK);
                }
            }
        }

        private void button_RemoveEmployee_Click(object sender, RoutedEventArgs e)
        {
            if (list_employees.SelectedItem == null)
            {
                return;
            }

            var result = MessageBox.Show("Are you sure you want to remove an employee record", "Warning", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                Service.RemoveEmployee(list_employees.SelectedItem as Employee);
                ListEmployees();
            }
            else
            {
                return;
            }
        }


    }
}