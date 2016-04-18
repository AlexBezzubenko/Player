using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using TestApp.Model;

namespace TestApp.Commands.Main
{
    public class ChangeCurrentCommand : ICommand
    {     
        public ChangeCurrentCommand()
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

            ListBox l = (ListBox)parameter;
            Playlist p = (Playlist)l.DataContext;
            if (p == null)
            {
                return;
            }
            p.CurrentTrack = (Track)l.SelectedItem;
                //playlist.CurrentTrack = (Track)parameter;
                    
                      
        }           
    }
}