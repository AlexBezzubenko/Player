using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TestApp.Model;
using TestApp.View;

namespace TestApp.Commands.Main
{
    public class CloseButtonEnterCommand : ICommand
    {
        public CloseButtonEnterCommand()
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
            if (parameter != null)
            {
                var closeButton = parameter as Button;
                closeButton.Width = 30;
                closeButton.Height = 30;
            }                             
        }  
    }
}