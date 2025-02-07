﻿using CodectoryCore.UI.Wpf;
using System.Windows;

namespace AutoHDR.Views
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class AutoHDRMainView : MainWindowBase
    {
        public AutoHDRMainView()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            Properties.Settings.Default.Width = Width;
            Properties.Settings.Default.Height = Height;
            Properties.Settings.Default.Save();
            this.Hide();
        }

 
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                Width = Properties.Settings.Default.Width;
                Height = Properties.Settings.Default.Height;

            }
            catch  { }       
        }
    }
}
