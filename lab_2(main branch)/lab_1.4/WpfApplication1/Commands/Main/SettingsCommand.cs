using System;
using System.Windows.Controls;
using System.Windows.Input;
using TestApp.Model;
using TestApp.View;
using TestApp.ViewModel;

namespace TestApp.Commands.Main
{
    public class SettingsCommand : ICommand
    {
        private Model.Settings settings;
        public SettingsCommand(Model.Settings settings)
        {
            this.settings = settings;
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
            SettingsWindowView settingsWindow = new SettingsWindowView(settings);
            if (parameter != null)
            {               
                settingsWindow.Owner = parameter as MainWindowView;
                settingsWindow.Top = settingsWindow.Owner.Top;
                settingsWindow.Left = settingsWindow.Owner.Left;
                settingsWindow.ShowDialog();
            }                     
        }
    }
}