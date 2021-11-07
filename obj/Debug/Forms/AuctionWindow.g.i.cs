﻿#pragma checksum "..\..\..\Forms\AuctionWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AB2AC13E10D351024AFB473B08E317A6CDAF56D94CFC4207967F5BDF004EABE7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using LandConquest.Forms;
using LandConquest.Resources;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using WPFLocalizeExtension.Deprecated.Engine;
using WPFLocalizeExtension.Deprecated.Extensions;
using WPFLocalizeExtension.Deprecated.Providers;
using WPFLocalizeExtension.Engine;
using WPFLocalizeExtension.Extensions;
using WPFLocalizeExtension.Providers;
using WPFLocalizeExtension.TypeConverters;
using WPFLocalizeExtension.ValueConverters;


namespace LandConquest.Forms {
    
    
    /// <summary>
    /// AuctionWindow
    /// </summary>
    public partial class AuctionWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\Forms\AuctionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid auctionDataGrid;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Forms\AuctionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn resourceQty;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Forms\AuctionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn itemName;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Forms\AuctionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn timeLeft;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Forms\AuctionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn sellersName;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Forms\AuctionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn totalPrice;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Forms\AuctionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonShowMyListings;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Forms\AuctionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonCreateListing;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Forms\AuctionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonClose;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Forms\AuctionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonBuy;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\Forms\AuctionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonFindListing;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Forms\AuctionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonUpdateListings;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\Forms\AuctionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxItemSearchName;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Forms\AuctionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonDelete;
        
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
            System.Uri resourceLocater = new System.Uri("/LandConquest;component/forms/auctionwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Forms\AuctionWindow.xaml"
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
            
            #line 16 "..\..\..\Forms\AuctionWindow.xaml"
            ((LandConquest.Forms.AuctionWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.auctionDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 30 "..\..\..\Forms\AuctionWindow.xaml"
            this.auctionDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.auctionDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.resourceQty = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 4:
            this.itemName = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 5:
            this.timeLeft = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 6:
            this.sellersName = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 7:
            this.totalPrice = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 8:
            this.buttonShowMyListings = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\Forms\AuctionWindow.xaml"
            this.buttonShowMyListings.Click += new System.Windows.RoutedEventHandler(this.buttonShowMyListings_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.buttonCreateListing = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\Forms\AuctionWindow.xaml"
            this.buttonCreateListing.Click += new System.Windows.RoutedEventHandler(this.buttonCreateListing_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.buttonClose = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\Forms\AuctionWindow.xaml"
            this.buttonClose.Click += new System.Windows.RoutedEventHandler(this.buttonClose_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.buttonBuy = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\..\Forms\AuctionWindow.xaml"
            this.buttonBuy.Click += new System.Windows.RoutedEventHandler(this.buttonBuy_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.buttonFindListing = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\..\Forms\AuctionWindow.xaml"
            this.buttonFindListing.Click += new System.Windows.RoutedEventHandler(this.buttonFindListing_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.buttonUpdateListings = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\..\Forms\AuctionWindow.xaml"
            this.buttonUpdateListings.Click += new System.Windows.RoutedEventHandler(this.buttonUpdateListings_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.textBoxItemSearchName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            this.buttonDelete = ((System.Windows.Controls.Button)(target));
            
            #line 90 "..\..\..\Forms\AuctionWindow.xaml"
            this.buttonDelete.Click += new System.Windows.RoutedEventHandler(this.buttonDelete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

