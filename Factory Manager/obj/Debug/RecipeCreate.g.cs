﻿#pragma checksum "..\..\RecipeCreate.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "626434C5579FD15F9F8748CFD0CE78DA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using RootLibrary.WPF.Localization;
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


namespace Factory_Manager {
    
    
    /// <summary>
    /// RecipeCreate
    /// </summary>
    public partial class RecipeCreate : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\RecipeCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox recipeCode;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\RecipeCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox recipeName;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\RecipeCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox recipeDetail;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\RecipeCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox recipeMaterial;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\RecipeCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button recBtn;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\RecipeCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox materialList;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\RecipeCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox materialName;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\RecipeCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button delBtn;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\RecipeCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clearBtn;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\RecipeCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addBtn;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\RecipeCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox materialAmount;
        
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
            System.Uri resourceLocater = new System.Uri("/Factory Manager;component/recipecreate.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RecipeCreate.xaml"
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
            this.recipeCode = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.recipeName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.recipeDetail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.recipeMaterial = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.recBtn = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\RecipeCreate.xaml"
            this.recBtn.Click += new System.Windows.RoutedEventHandler(this.recBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.materialList = ((System.Windows.Controls.ComboBox)(target));
            
            #line 15 "..\..\RecipeCreate.xaml"
            this.materialList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.materialList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.materialName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.delBtn = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\RecipeCreate.xaml"
            this.delBtn.Click += new System.Windows.RoutedEventHandler(this.delBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.clearBtn = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\RecipeCreate.xaml"
            this.clearBtn.Click += new System.Windows.RoutedEventHandler(this.clearBtn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.addBtn = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\RecipeCreate.xaml"
            this.addBtn.Click += new System.Windows.RoutedEventHandler(this.addBtn_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.materialAmount = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\RecipeCreate.xaml"
            this.materialAmount.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.materialAmount_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

