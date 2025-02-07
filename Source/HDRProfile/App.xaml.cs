﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using AutoHDR.ProjectResources;

namespace AutoHDR
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    ///

    public partial class App : Application
    {
        static Mutex mutex;

        [STAThread]
        public static void Main()
         {
            bool createNew = false;
            mutex = new Mutex(true, "{2846416C-610B-4A6B-A31C-A4AA6826E9BE}", out createNew);
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                var application = new App();
                application.InitializeComponent();
                application.Run();
            }
            else
            {
                MessageBox.Show(Locale_Texts.AlreadyRunning);
            }
        }

        protected override void OnExit(ExitEventArgs e)
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
                mutex.ReleaseMutex();

        }
    }
}
