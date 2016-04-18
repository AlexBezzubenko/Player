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
    public class StopChangeCommand : ICommand
    {
        public StopChangeCommand()
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
            var IsChecked = (bool)parameter;
            var model = (MainWindowViewModel)Application.Current.MainWindow.DataContext;
            model.Settings.StopAll = IsChecked;
            model.Settings.Serialize();
        }
    }
}