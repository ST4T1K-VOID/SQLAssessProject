﻿using System;
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
        public UpdateEmployeeWindow()
        {
            InitializeComponent();

        }

        private void button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            UpdateEmployeeWindow.GetWindow(this).Close();
        }

        private void button_Confirm_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
