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
            button_getSales.IsEnabled = true;

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

                if (Service.AddEmployee(tempFirstName, tempLastName, (GenderEnum)addEmployeeWindow.combo_gender.SelectedItem, DateOnly.Parse(addEmployeeWindow.datepicker_dateOfBirth.Text), tempSalary, tempBranchID, tempSupervisorID))
                {
                    MessageBox.Show("Employee added", "Operation successful", MessageBoxButton.OK);
                }
                else
                {
                    MessageBox.Show("Employee could not be added", "Operation unsuccessful", MessageBoxButton.OK);
                }
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

                Employee updatedEmployee = new Employee(oldEmployee.ID, updatedFirstName, updatedLastName, tempgender, oldEmployee.DateOfBirth, updatedSalary, updatedBranchID, updatedSupervisorID);
                if (Service.UpdateEmployee(oldEmployee, updatedEmployee))
                {
                    MessageBox.Show("Employee updated", "Successful Operation", MessageBoxButton.OK);
                    ListEmployees();
                }
                //else
                //{
                //    MessageBox.Show("Employee under that name already exsists", "Unsuccessful Operation", MessageBoxButton.OK);
                //}
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
                if (Service.RemoveEmployee(list_employees.SelectedItem as Employee))
                {
                    MessageBox.Show("Employee removed", "Operation successful", MessageBoxButton.OK);
                    ListEmployees();
                    textbox_FirstName.Text = null;
                    textbox_LastName.Text = null;
                    textbox_EmployeeID.Text = null;
                    textbox_Salary.Text = null;
                    textbox_BranchID.Text = null;
                    textbox_SupervisorID.Text = null;
                    textbox_dateOfBirth.Text = null;
                    textbox_gender.Text = null;
                }
                else
                {
                    MessageBox.Show("Failed to remove employee", "operation unsuccessful", MessageBoxButton.OK);
                }
            }
        }

        private void button_filter_Click(object sender, RoutedEventArgs e)
        {
            FilterWindow filterWindow = new FilterWindow();
            filterWindow.ShowDialog();

            if (filterWindow.DialogResult == true)
            {
                Filter? filter = filterWindow.filter;
                if (filter == Filter.byName)
                {
                    string firstName = filterWindow.textbox_firstName.Text;
                    string lastName = filterWindow.textbox_LastName.Text;
                    
                    List<Employee> filteredemployees = Service.FilterEmployeesByName(firstName, lastName);

                    if (filteredemployees == null)
                    {
                        MessageBox.Show("Employees with that name could not be found", "Employees not found", MessageBoxButton.OK);
                        return;
                    }
                    else
                    {
                        list_employees.ItemsSource = null;
                        list_employees.ItemsSource = filteredemployees;
                    }
                    
                }
                else if (filter == Filter.bySalary)
                {
                    int max = -1;
                    int min = -1;
                    int.TryParse(filterWindow.textbox_maxRange.Text, out max);
                    int.TryParse(filterWindow.textbox_minRange.Text, out min);

                    if (max == -1 || min == -1)
                    {
                        MessageBox.Show("ERROR: invalid input", "ERROR", MessageBoxButton.OK);
                        return;
                    }
                    list_employees.ItemsSource = null;
                    list_employees.ItemsSource = Service.FilterEmployeesBySalary(max, min);
                }

                else if (filter == Filter.byBranch)
                {
                    List<Employee> employees = Service.FilterEmployeesByBranch(int.Parse(filterWindow.textbox_branchID.Text));
                    if (employees.Count == 0)
                    {
                        MessageBox.Show($"There are no Employees found with branch ID {filterWindow.textbox_branchID.Text}", "No Employees Found", MessageBoxButton.OK);
                        return;
                    }
                    list_employees.ItemsSource= null;
                    list_employees.ItemsSource = employees;
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
        }

        private void button_getSales_Click(object sender, RoutedEventArgs e)
        {
            if (list_employees.SelectedItem == null)
            {
                return;
            }
            Employee employee = list_employees.SelectedItem as Employee;
            string sales = Service.GetEmployeeSales(employee.ID);

            MessageBox.Show(sales, "TOTAL SALES",MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}