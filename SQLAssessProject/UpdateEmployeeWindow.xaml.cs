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
            combo_gender.ItemsSource = Enum.GetValues(typeof(GenderEnum));
            textbox_firstName.Text = selectedEmployee.FirstName;
            textbox_lastName.Text = selectedEmployee.LastName;
            //combo_gender.SelectedIndex = Enum.GetName(selectedEmployee.Gender).ToString();
            textbox_salary.Text = selectedEmployee.GrossSalary.ToString();

        }

        private void button_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_confirm_Click(object sender, RoutedEventArgs e)
        {
            if (!textbox_firstName.Text.All(char.IsLetter) || !textbox_lastName.Text.All(char.IsLetter))
            {
                MessageBox.Show("First and last name can only contain letters.", "ERROR", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            //bool checkResult = textbox_firstName.Text.All(char.IsLetter);
        }
    }
}
