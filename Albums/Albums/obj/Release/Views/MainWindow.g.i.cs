﻿#pragma checksum "..\..\..\Views\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2BF00A7E3D1FC15C7C08A18F17E7E5BC1EA9CC76F5D8FA9AD7DEA3407C44A3E0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Albums;
using Albums.Models;
using Albums.ViewModels;
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
using System.Windows.Interactivity;
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
using WpfToolkit.Controls;


namespace Albums {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Albums.ViewModels.AlbumViewModel main;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox AlbumList;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox PhotoList;
        
        #line default
        #line hidden
        
        
        #line 173 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid overlay;
        
        #line default
        #line hidden
        
        
        #line 196 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock overlayText;
        
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
            System.Uri resourceLocater = new System.Uri("/Albums;component/views/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\MainWindow.xaml"
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
            
            #line 12 "..\..\..\Views\MainWindow.xaml"
            ((Albums.MainWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.main = ((Albums.ViewModels.AlbumViewModel)(target));
            return;
            case 3:
            this.AlbumList = ((System.Windows.Controls.ListBox)(target));
            return;
            case 4:
            this.PhotoList = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.overlay = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.overlayText = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

