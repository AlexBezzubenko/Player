using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TestApp.Model;
using TestApp.View;
using TestApp.ViewModel;

namespace TestApp.Commands.Main
{
    public class AddTabItemCommand : ICommand
    {
        public AddTabItemCommand()
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
            var tab = parameter as TabControl;
            if (tab.Items.Count < 10)
            {
                TabItem item = new TabItem();

                item.Header = "New_Playlist";
                //var newChild = new ListBox();
                //item.Content = newChild;               
                tab.Items.Insert(tab.Items.Count - 1, item);
                Playlist p = new Playlist();
                p.Add(new Track());
                item.Content = p;
            }
        }
    }
}