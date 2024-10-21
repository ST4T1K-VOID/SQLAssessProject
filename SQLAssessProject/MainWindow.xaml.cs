using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
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
                
            }
            textbox_FirstName.Text = selectedEmployee.FirstName;
            textbox_LastName.Text = selectedEmployee.LastName;
            textbox_EmployeeID.Text = selectedEmployee.ID.ToString();
            textbox_Salary.Text = selectedEmployee.GrossSalary.ToString();
            textbox_BranchID.Text = selectedEmployee.BranchID.ToString();
            textbox_SupervisorID.Text = selectedEmployee.SupervisorID.ToString();
        }

        private void button_AddEmployee_Click(object sender, RoutedEventArgs e)
        {
            AddEmployeeWindow addEmployeeWindow = new AddEmployeeWindow();
            addEmployeeWindow.Show();
        }

        private void button_UpdateEmployee_Click(object sender, RoutedEventArgs e)
        {
            if (list_employees.SelectedItem == null)
            {
                return;
            }
            Employee selectedEmployee = list_employees.SelectedItem as Employee;
            UpdateEmployeeWindow updateEmployeeWindow = new UpdateEmployeeWindow();
            updateEmployeeWindow.Show();
        }
    }
}