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
    public class ChangeVolumeCommand : ICommand
    {     
        public ChangeVolumeCommand()
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

            if (values[0].GetType() != typeof(Playlist))
            {
                return;
            }
            var p = (Playlist)values[0];
            var v = (double)values[1];
           
            p.Player.Volume = v / 100;
                       
        }           
    }
}