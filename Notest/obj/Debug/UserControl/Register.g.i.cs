﻿#pragma checksum "..\..\..\UserControl\Register.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C412BBBEDE0631A22EC9D7CD3D6AF26027121EBC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using Notest.UserControl;
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


namespace Notest.UserControl {
    
    
    /// <summary>
    /// Register
    /// </summary>
    public partial class Register : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\UserControl\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NewLogin;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\UserControl\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Alert_NewLogin;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\UserControl\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox NewPassword;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\UserControl\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Alert_NewPassword;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\UserControl\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox UserType;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\UserControl\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button registrationButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Notest;component/usercontrol/register.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControl\Register.xaml"
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
            this.NewLogin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Alert_NewLogin = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.NewPassword = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 46 "..\..\..\UserControl\Register.xaml"
            this.NewPassword.PasswordChanged += new System.Windows.RoutedEventHandler(this.OnPasswordChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Alert_NewPassword = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.UserType = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.registrationButton = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\..\UserControl\Register.xaml"
            this.registrationButton.Click += new System.Windows.RoutedEventHandler(this.OnRegisterButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

