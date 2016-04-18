using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TestApp.Model;
using TestApp.View;

namespace TestApp.Commands.Main
{
    public class CloseButtonLeaveCommand : ICommand
    {
        private Playlist playlist;
        public CloseButtonLeaveCommand()
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
                closeButton.Width = 24;
                closeButton.Height = 24;
            }                             
        }  
    }
}