﻿#pragma checksum "..\..\..\AddEmployeeWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30CBEC562EC51161CD8C3B626709B344B4E81BCA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SQLproject;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace SQLproject {
    
    
    /// <summary>
    /// AddEmployeeWindow
    /// </summary>
    public partial class AddEmployeeWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\AddEmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_firstName;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\AddEmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_lastName;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\AddEmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combo_gender;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\AddEmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_salary;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\AddEmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datepicker_dateOfBirth;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\AddEmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_supervisorID;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\AddEmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_branchID;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\AddEmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_confirm;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\AddEmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_cancel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SQLproject;component/addemployeewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddEmployeeWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.textbox_firstName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.textbox_lastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.combo_gender = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.textbox_salary = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.datepicker_dateOfBirth = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.textbox_supervisorID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.textbox_branchID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.button_confirm = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\AddEmployeeWindow.xaml"
            this.button_confirm.Click += new System.Windows.RoutedEventHandler(this.button_confirm_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.button_cancel = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\AddEmployeeWindow.xaml"
            this.button_cancel.Click += new System.Windows.RoutedEventHandler(this.button_cancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

