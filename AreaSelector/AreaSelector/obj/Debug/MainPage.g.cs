﻿#pragma checksum "C:\WP_Projects\WP8Examples\WP8MapsExamples\AreaSelector\AreaSelector\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "29ACCE183225897A889EDB99EB0D4523"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace AreaSelector {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox LatitudeBox;
        
        internal System.Windows.Controls.TextBox LongittudeBox;
        
        internal System.Windows.Controls.TextBox StringBox;
        
        internal System.Windows.Controls.Button getGeoButton;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/AreaSelector;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.LatitudeBox = ((System.Windows.Controls.TextBox)(this.FindName("LatitudeBox")));
            this.LongittudeBox = ((System.Windows.Controls.TextBox)(this.FindName("LongittudeBox")));
            this.StringBox = ((System.Windows.Controls.TextBox)(this.FindName("StringBox")));
            this.getGeoButton = ((System.Windows.Controls.Button)(this.FindName("getGeoButton")));
        }
    }
}

