﻿#pragma checksum "..\..\LunchMenu.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FBDA5AD94B96D4D587312C157CE4C1C0F887B8BFA1572ACDF764F0873E07E4B0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ordering_System;
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


namespace Ordering_System {
    
    
    /// <summary>
    /// LunchMenu
    /// </summary>
    public partial class LunchMenu : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 177 "..\..\LunchMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DOWN;
        
        #line default
        #line hidden
        
        
        #line 195 "..\..\LunchMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox App_Count1;
        
        #line default
        #line hidden
        
        
        #line 196 "..\..\LunchMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox App_Count2;
        
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
            System.Uri resourceLocater = new System.Uri("/Ordering System;component/lunchmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LunchMenu.xaml"
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
            
            #line 15 "..\..\LunchMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Add_Burger_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 25 "..\..\LunchMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Minus_Burger_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 36 "..\..\LunchMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Add_Shrimp_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 46 "..\..\LunchMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Minus_Shrimp_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 56 "..\..\LunchMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.My_Order_Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 64 "..\..\LunchMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Server_Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 73 "..\..\LunchMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Bill_Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 85 "..\..\LunchMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Burger_Add_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 95 "..\..\LunchMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Shrimp_Add_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 108 "..\..\LunchMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Appetizer_Button_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 116 "..\..\LunchMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Breakfast_Button_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 135 "..\..\LunchMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Dinner_Button_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 143 "..\..\LunchMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Dessert_Button_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 151 "..\..\LunchMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Drinks_Button_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 159 "..\..\LunchMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Help_Button_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 167 "..\..\LunchMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoBack_Button_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            this.DOWN = ((System.Windows.Controls.Button)(target));
            
            #line 177 "..\..\LunchMenu.xaml"
            this.DOWN.Click += new System.Windows.RoutedEventHandler(this.DOWN_Button_Click);
            
            #line default
            #line hidden
            return;
            case 18:
            this.App_Count1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 19:
            this.App_Count2 = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

