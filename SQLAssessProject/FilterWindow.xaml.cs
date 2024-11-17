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
using SQLproject;

namespace SQLproject
{
    /// <summary>
    /// Interaction logic for FilterWindow.xaml
    /// </summary>
    public partial class FilterWindow : Window
    {
        public FilterWindow()
        {
            InitializeComponent();
            textbox_firstName.IsEnabled = false;
            textbox_LastName.IsEnabled = false;
            textbox_minRange.IsEnabled = false;
            textbox_maxRange.IsEnabled = false;
            textbox_branchID.IsEnabled = false;
        }

       

        public Filter? filter = null;

        private void check_byName_Checked(object sender, RoutedEventArgs e)
        {
            filter = Filter.byName;
            check_byBranch.IsChecked = false;
            check_bySalary.IsChecked = false;

            textbox_firstName.IsEnabled = true;
            textbox_LastName.IsEnabled = true;
            textbox_maxRange.IsEnabled = false;
            textbox_minRange.IsEnabled = false;
            textbox_branchID.IsEnabled = false;
        }

        private void check_bySalary_Checked(object sender, RoutedEventArgs e)
        {
            filter = Filter.bySalary;
            check_byName.IsChecked = false;
            check_byBranch.IsChecked = false;

            textbox_firstName.IsEnabled = false;
            textbox_LastName.IsEnabled = false;
            textbox_maxRange.IsEnabled = true;
            textbox_minRange.IsEnabled = true;
            textbox_branchID.IsEnabled = false;
        }

        private void check_byBranch_Checked(object sender, RoutedEventArgs e)
        {
            filter = Filter.byBranch;
            check_byName.IsChecked = false;
            check_bySalary.IsChecked=false;

            textbox_firstName.IsEnabled = false;
            textbox_LastName.IsEnabled = false;
            textbox_maxRange.IsEnabled = false;
            textbox_minRange.IsEnabled = false;
            textbox_branchID.IsEnabled = true;
        }

        private void button_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void button_confirm_Click(object sender, RoutedEventArgs e)
        {
            if (filter == null)
            {
                MessageBox.Show("Select a filter", "No filter selected", MessageBoxButton.OK);
                return;
            }
            else if (filter == Filter.byName)
            {
                if (!textbox_firstName.Text.All(char.IsLetter) || !textbox_LastName.Text.All(char.IsLetter))
                {
                    MessageBox.Show("First and last name may only contain letters", "Invalid input", MessageBoxButton.OK);
                    return;
                }
                else if (textbox_firstName.Text == string.Empty && textbox_LastName.Text == string.Empty )
                {
                    MessageBox.Show("First and last name must be filled", "empty fields", MessageBoxButton.OK);
                    return;
                }
                else
                {
                    this.DialogResult = true;
                    this.Close();
                }
            }
            else if (filter == Filter.bySalary)
            {
                if (!textbox_minRange.Text.All(char.IsDigit) || !textbox_maxRange.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Min and max range may only contain numbers", "Invalid input", MessageBoxButton.OK);
                    return;
                }
                else if (!Int32.TryParse(textbox_minRange.Text, out int result) || !Int32.TryParse(textbox_maxRange.Text, out int result1))
                {
                    MessageBox.Show("Input value is outside of acceptable range", "ERROR", MessageBoxButton.OK);
                }

                else if (textbox_minRange.Text == string.Empty && textbox_maxRange.Text == string.Empty)
                {
                    MessageBox.Show("Min and max range must be filled", "empty fields", MessageBoxButton.OK);
                    return;
                }
                else if (int.Parse(textbox_minRange.Text) > int.Parse(textbox_maxRange.Text))
                {
                    MessageBox.Show("Min range cannot be greater than max range", "Invalid input", MessageBoxButton.OK);
                    return;
                }
                else
                {
                    this.DialogResult = true;
                    this.Close();
                }
            }
            else if (filter == Filter.byBranch)
            {
                if (!textbox_branchID.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Branch ID must be a number", "invalid input", MessageBoxButton.OK);
                    return;
                }
                else if (!long.TryParse(textbox_branchID.Text, out long result))
                {
                    MessageBox.Show("Input value is outside of acceptable range", "ERROR", MessageBoxButton.OK);
                }
                else if (textbox_branchID.Text == string.Empty)
                {
                    MessageBox.Show("branch ID must be filled", "Empty fields", MessageBoxButton.OK);
                }
                else
                {
                    this.DialogResult= true;
                    this.Close();
                }
            }
            else
            {
                return;
            }
        }
    }
}
