﻿#pragma checksum "..\..\..\..\Pages\Windows\AdministratorAddAndEdit.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "04851E0A4D5706005A9C61779DD9076E1542D0EF21EE1380DE0CEAE3288CDF49"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AppDemo.Pages.Windows;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace AppDemo.Pages.Windows {
    
    
    /// <summary>
    /// AdministratorAddAndEdit
    /// </summary>
    public partial class AdministratorAddAndEdit : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\Pages\Windows\AdministratorAddAndEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxIDclient;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Pages\Windows\AdministratorAddAndEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxService;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\Pages\Windows\AdministratorAddAndEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxIDstatus;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\Pages\Windows\AdministratorAddAndEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datePickerDateClose;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Pages\Windows\AdministratorAddAndEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxTimeRent;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Pages\Windows\AdministratorAddAndEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonAddOrEdit;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AppDemo;component/pages/windows/administratoraddandedit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Windows\AdministratorAddAndEdit.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\..\Pages\Windows\AdministratorAddAndEdit.xaml"
            ((AppDemo.Pages.Windows.AdministratorAddAndEdit)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.textBoxIDclient = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.textBoxService = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.comboBoxIDstatus = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.datePickerDateClose = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.textBoxTimeRent = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.buttonAddOrEdit = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\..\Pages\Windows\AdministratorAddAndEdit.xaml"
            this.buttonAddOrEdit.Click += new System.Windows.RoutedEventHandler(this.buttonAddOrEdit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

