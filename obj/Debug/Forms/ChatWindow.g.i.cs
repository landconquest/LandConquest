﻿#pragma checksum "..\..\..\Forms\ChatWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "328D0CB50E9F35FAD5F15572601DD66BC7553DCA12D88EE96D93748E5B1800A1"
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
    /// ChatWindow
    /// </summary>
    public partial class ChatWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\Forms\ChatWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxNewMessage;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Forms\ChatWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listViewChat;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Forms\ChatWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonSendMessage;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Forms\ChatWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonToAll;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Forms\ChatWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonClose;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Forms\ChatWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button viewProfile;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\Forms\ChatWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border borderSendTo;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\Forms\ChatWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridSendTo;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\Forms\ChatWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblSendTo;
        
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
            System.Uri resourceLocater = new System.Uri("/LandConquest;component/forms/chatwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Forms\ChatWindow.xaml"
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
            
            #line 17 "..\..\..\Forms\ChatWindow.xaml"
            ((LandConquest.Forms.ChatWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.textBoxNewMessage = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.listViewChat = ((System.Windows.Controls.ListView)(target));
            
            #line 25 "..\..\..\Forms\ChatWindow.xaml"
            this.listViewChat.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listViewChat_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.buttonSendMessage = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\Forms\ChatWindow.xaml"
            this.buttonSendMessage.Click += new System.Windows.RoutedEventHandler(this.ButtonSendMessage_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.buttonToAll = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\Forms\ChatWindow.xaml"
            this.buttonToAll.Click += new System.Windows.RoutedEventHandler(this.buttonToAll_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttonClose = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\Forms\ChatWindow.xaml"
            this.buttonClose.Click += new System.Windows.RoutedEventHandler(this.ButtonClose_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.viewProfile = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\Forms\ChatWindow.xaml"
            this.viewProfile.Click += new System.Windows.RoutedEventHandler(this.viewProfile_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.borderSendTo = ((System.Windows.Controls.Border)(target));
            return;
            case 9:
            this.gridSendTo = ((System.Windows.Controls.Grid)(target));
            return;
            case 10:
            this.lblSendTo = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

