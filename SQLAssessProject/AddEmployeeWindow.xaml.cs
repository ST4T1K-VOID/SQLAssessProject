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
    /// Interaction logic for AddEmployeeWindow.xaml
    /// </summary>
    public partial class AddEmployeeWindow : Window
    {
        public AddEmployeeWindow()
        {
            InitializeComponent();
            combo_gender.ItemsSource = Enum.GetValues(typeof(GenderEnum));
        }

        private void button_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void button_confirm_Click(object sender, RoutedEventArgs e)
        {
            if (!textbox_firstName.Text.All(char.IsLetter) || !textbox_lastName.Text.All(char.IsLetter))
            {
                MessageBox.Show("first and last name can only contain letters", "Invalid Input", MessageBoxButton.OK);
                return;
            }
            else if (textbox_firstName.Text == string.Empty || textbox_lastName.Text == string.Empty)
            {
                MessageBox.Show("All fields must be filled","Empyt Fields",MessageBoxButton.OK);
                return;
            }

            if (!textbox_salary.Text.All(char.IsDigit) || !textbox_supervisorID.Text.All(char.IsDigit) || !textbox_branchID.Text.All(char.IsDigit))
            {
                MessageBox.Show("Salary, supervisor ID and branch ID can onlt contain numbers", "Invalid Input", MessageBoxButton.OK);
                return;
            }
            else if (textbox_salary.Text == string.Empty || textbox_supervisorID.Text == string.Empty || textbox_branchID.Text == string.Empty)
            {
                MessageBox.Show("All fields must be filled", "Empyt Fields", MessageBoxButton.OK);
                return;
            }

            if (combo_gender.Text == string.Empty || datepicker_dateOfBirth.Text == string.Empty)
            {
                MessageBox.Show("All fields must be filled", "Empyt Fields", MessageBoxButton.OK);
                return;
            }

            this.DialogResult = true;
            this.Close();
        }
    }
}