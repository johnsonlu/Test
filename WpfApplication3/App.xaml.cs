﻿namespace WpfApplication3
{
    using System.Windows;

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var mainViewModel = new MainViewModel();
            var mainWindow = new MainWindow {DataContext = mainViewModel };

            mainWindow.Show();
        }
    }
}
