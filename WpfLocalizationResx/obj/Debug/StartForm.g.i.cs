﻿#pragma checksum "..\..\StartForm.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "02E6CE328D11EE8DB3078A6737CF8DB9"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

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
using Westwind.Wpf.Controls;


namespace WpfLocalizationResx {
    
    
    /// <summary>
    /// StartForm
    /// </summary>
    public partial class StartForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\StartForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WpfLocalizationResx.StartForm frmStartMenuForm;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\StartForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grdPage;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\StartForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel stackOuter;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\StartForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock WindowHeader;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\StartForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLocalizationInfo;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\StartForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLocalizationInfoAttached;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\StartForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnExit;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfLocalizationResx;component/startform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\StartForm.xaml"
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
            this.frmStartMenuForm = ((WpfLocalizationResx.StartForm)(target));
            return;
            case 2:
            this.grdPage = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.stackOuter = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.WindowHeader = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.btnLocalizationInfo = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\StartForm.xaml"
            this.btnLocalizationInfo.Click += new System.Windows.RoutedEventHandler(this.ButtonHandler);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnLocalizationInfoAttached = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\StartForm.xaml"
            this.btnLocalizationInfoAttached.Click += new System.Windows.RoutedEventHandler(this.ButtonHandler);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnExit = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\StartForm.xaml"
            this.btnExit.Click += new System.Windows.RoutedEventHandler(this.ButtonHandler);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

