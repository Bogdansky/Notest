﻿#pragma checksum "..\..\..\User\ChooseTest.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5AEEF52B0843700E595087B7BF762D576FCD4351"
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
using Notest;
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


namespace Notest {
    
    
    /// <summary>
    /// ChooseTest
    /// </summary>
    public partial class ChooseTest : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\User\ChooseTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Fullscreen;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\User\ChooseTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FullscreenExit;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\User\ChooseTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Topic;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\User\ChooseTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Header;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\User\ChooseTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel SelectedTest;
        
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
            System.Uri resourceLocater = new System.Uri("/Notest;component/user/choosetest.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\User\ChooseTest.xaml"
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
            
            #line 9 "..\..\..\User\ChooseTest.xaml"
            ((Notest.ChooseTest)(target)).Loaded += new System.Windows.RoutedEventHandler(this.OnStartTest);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 23 "..\..\..\User\ChooseTest.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.HideWindow_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Fullscreen = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\User\ChooseTest.xaml"
            this.Fullscreen.Click += new System.Windows.RoutedEventHandler(this.Fullscreen_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.FullscreenExit = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\User\ChooseTest.xaml"
            this.FullscreenExit.Click += new System.Windows.RoutedEventHandler(this.FullscreenExit_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 60 "..\..\..\User\ChooseTest.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseWindow_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Topic = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.Header = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.SelectedTest = ((System.Windows.Controls.StackPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

