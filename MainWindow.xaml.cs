using System;
using System.Windows;
using Microsoft.Web.WebView2.Core;

namespace NightBrowser.UI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            await Browser.EnsureCoreWebView2Async();
            Browser.CoreWebView2.Navigate("https://example.com");
        }
    }
}