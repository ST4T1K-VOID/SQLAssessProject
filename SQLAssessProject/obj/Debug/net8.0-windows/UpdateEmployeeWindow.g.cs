﻿#pragma checksum "..\..\..\UpdateEmployeeWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55322011FF9DE588B1935D1833C22AA3B194AA97"
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
    /// UpdateEmployeeWindow
    /// </summary>
    public partial class UpdateEmployeeWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\UpdateEmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_FirstName;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\UpdateEmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_LastName;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\UpdateEmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datebox_DOB;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\UpdateEmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_Salary;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\UpdateEmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_BranchID;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\UpdateEmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_SupervisorID;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\UpdateEmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Confirm;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\UpdateEmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Cancel;
        
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
            System.Uri resourceLocater = new System.Uri("/SQLproject;component/updateemployeewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UpdateEmployeeWindow.xaml"
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
            this.textbox_FirstName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.textbox_LastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.datebox_DOB = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.textbox_Salary = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.textbox_BranchID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.textbox_SupervisorID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.button_Confirm = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.button_Cancel = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\UpdateEmployeeWindow.xaml"
            this.button_Cancel.Click += new System.Windows.RoutedEventHandler(this.button_Cancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

