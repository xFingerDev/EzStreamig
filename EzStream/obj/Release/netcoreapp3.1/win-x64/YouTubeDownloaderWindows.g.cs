﻿#pragma checksum "..\..\..\..\YouTubeDownloaderWindows.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C47528C8D8C10D49D7ECC3FA08608304B3FA6A57"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using EzStreaming;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace EzStreaming {
    
    
    /// <summary>
    /// YouTubeDownloaderWindows
    /// </summary>
    public partial class YouTubeDownloaderWindows : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 12 "..\..\..\..\YouTubeDownloaderWindows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ytlink;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\YouTubeDownloaderWindows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox settings_video;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\YouTubeDownloaderWindows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox settings_audio;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\YouTubeDownloaderWindows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bgrided;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\YouTubeDownloaderWindows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox resultTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/EzStreaming;V2.0.5.1;component/youtubedownloaderwindows.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\YouTubeDownloaderWindows.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 10 "..\..\..\..\YouTubeDownloaderWindows.xaml"
            ((EzStreaming.YouTubeDownloaderWindows)(target)).Loaded += new System.Windows.RoutedEventHandler(this.App_load);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\..\YouTubeDownloaderWindows.xaml"
            ((EzStreaming.YouTubeDownloaderWindows)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Windows_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ytlink = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\..\..\YouTubeDownloaderWindows.xaml"
            this.ytlink.KeyUp += new System.Windows.Input.KeyEventHandler(this.linkyt_keyup);
            
            #line default
            #line hidden
            return;
            case 3:
            this.settings_video = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.settings_audio = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.bgrided = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\..\YouTubeDownloaderWindows.xaml"
            this.bgrided.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.resultTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 6:
            
            #line 65 "..\..\..\..\YouTubeDownloaderWindows.xaml"
            ((System.Windows.Controls.ProgressBar)(target)).ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.pgbarr_ValueChanged);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

