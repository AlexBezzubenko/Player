using System;
using System.Windows.Input;
using TestApp.Model;
using TestApp.View;
using System.Windows;

namespace TestApp.Commands
{
    public class ReturnCommand : ICommand
    {
        private Window window;
        public ReturnCommand(Window window)
        {
            this.window = window;
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

        public void Execute(object parametr)
        {
            window.Close();
        }
    }
}