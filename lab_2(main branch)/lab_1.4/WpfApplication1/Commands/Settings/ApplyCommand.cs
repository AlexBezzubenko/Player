using System;
using System.Globalization;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TestApp.Model;
using TestApp.View;
using TestApp.ViewModel;

namespace TestApp.Commands.Settings
{
    public class ApplyCommand : ICommand
    {
        public ApplyCommand()
        {
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            if (parameter == null)
            {
                return;
            }
            var values = (object[])parameter;
            var index = (int)values[1];
            var IsChecked = (bool)values[0];
            if (index == -1) return;

            string lang = String.Empty;
            if (index == 0) { lang = "ru-Ru"; }

            var model = (MainWindowViewModel)Application.Current.MainWindow.DataContext;
            model.Settings.Language = lang;
            model.Settings.Serialize();

            if (IsChecked)
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo(lang);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
                var oldWindow = Application.Current.MainWindow;
                Application.Current.MainWindow = new MainWindowView();
                Application.Current.MainWindow.Show();
                oldWindow.Close();
            }
            if (!IsChecked)
            {
                Application.Current.MainWindow.OwnedWindows[0].Close();
            }
        }
    }
}