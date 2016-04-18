using System;
using System.Windows.Controls;
using System.Windows.Input;
using TestApp.Model;
using TestApp.View;
using TestApp.ViewModel;

namespace TestApp.Commands.Main
{
    public class AboutCommand : ICommand
    {
        public AboutCommand()
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
            AboutWindowView aboutWindow = new AboutWindowView();
            if (parameter != null)
            {
                aboutWindow.Owner = parameter as MainWindowView;
            }
            aboutWindow.Top = aboutWindow.Owner.Top;
            aboutWindow.Left = aboutWindow.Owner.Left;
            aboutWindow.ShowDialog();
            
        }
    }
}