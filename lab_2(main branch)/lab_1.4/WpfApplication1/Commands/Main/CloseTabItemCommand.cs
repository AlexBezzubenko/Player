using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TestApp.Model;
using TestApp.View;
using TestApp.ViewModel;

namespace TestApp.Commands.Main
{
    public class CloseTabItemCommand : ICommand
    {
        public CloseTabItemCommand()
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
                //MessageBox.Show(parameter.GetType().ToString());
                var TI = parameter as TabItem;
                var tc = (TabControl)TI.Parent;
                tc.Items.Remove(TI);
                /*var tab = parameter as TabControl;

                tab.Items.RemoveAt(tab.SelectedIndex);*/
            }
        }
    }
}