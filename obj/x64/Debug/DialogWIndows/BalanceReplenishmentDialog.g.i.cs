﻿#pragma checksum "..\..\..\..\DialogWIndows\BalanceReplenishmentDialog.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0AC9EE92A685A4E1A25BB3BFCAEA0302CC38E512916FC5A364397DE7427FC85D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using LandConquest.DialogWIndows;
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


namespace LandConquest.DialogWIndows {
    
    
    /// <summary>
    /// BalanceReplenishmentDialog
    /// </summary>
    public partial class BalanceReplenishmentDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\DialogWIndows\BalanceReplenishmentDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox currencyAmount;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\DialogWIndows\BalanceReplenishmentDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label totalMoneyAmountLabel;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\DialogWIndows\BalanceReplenishmentDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonPurchase;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\DialogWIndows\BalanceReplenishmentDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image paypalPayment;
        
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
            System.Uri resourceLocater = new System.Uri("/LandConquest;component/dialogwindows/balancereplenishmentdialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\DialogWIndows\BalanceReplenishmentDialog.xaml"
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
            this.currencyAmount = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\..\..\DialogWIndows\BalanceReplenishmentDialog.xaml"
            this.currencyAmount.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.currencyAmount_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.totalMoneyAmountLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.buttonPurchase = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\..\DialogWIndows\BalanceReplenishmentDialog.xaml"
            this.buttonPurchase.Click += new System.Windows.RoutedEventHandler(this.buttonPurchase_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.paypalPayment = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

