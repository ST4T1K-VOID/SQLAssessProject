using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SQLproject
{
    /// <summary>
    /// Interaction logic for UpdateEmployeeWindow.xaml
    /// </summary>
    public partial class UpdateEmployeeWindow : Window
    {
        public UpdateEmployeeWindow(Employee selectedEmployee)
        {
            InitializeComponent();
            combo_gender.ItemsSource = Enum.GetNames(typeof(GenderEnum));
            textbox_firstName.Text = selectedEmployee.FirstName;
            textbox_lastName.Text = selectedEmployee.LastName;
            combo_gender.Text = selectedEmployee.Gender.ToString();
            textbox_salary.Text = selectedEmployee.GrossSalary.ToString();
            textbox_branchID.Text = selectedEmployee.BranchID.ToString();
            textbox_supervisorID.Text = selectedEmployee.SupervisorID.ToString();
        }

        private void button_cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }

        private void button_confirm_Click(object sender, RoutedEventArgs e)
        {
            if (textbox_firstName.Text == string.Empty || textbox_lastName.Text == string.Empty || textbox_branchID.Text == string.Empty || textbox_salary.Text == string.Empty || textbox_supervisorID.Text == string.Empty)
            {
                MessageBox.Show("All fields are required to be filled", "Unfilled fields", MessageBoxButton.OK);
                return;
            }
            if (!textbox_firstName.Text.All(char.IsLetter) || !textbox_lastName.Text.All(char.IsLetter))
            {
                MessageBox.Show("First and last name can only contain letters.", "ERROR", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            else if (!int.TryParse(textbox_salary.Text, out int result) || !int.TryParse(textbox_supervisorID.Text, out int result1) || !int.TryParse(textbox_supervisorID.Text, out int result2))
            {
                MessageBox.Show("salary and IDs can not contain letters or decimals", "ERROR", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            else
            {
                DialogResult = true;
                this.Close();
            }
        }
    }
}
