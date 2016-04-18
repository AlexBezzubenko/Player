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
    public class ChangePositionCommand : ICommand
    {     
        public ChangePositionCommand()
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

            int nv = (int)v;


            var t = p.CurrentTrack;

            TimeSpan new_pos = new TimeSpan(t.TrackLength.Ticks * nv / 100);

            p.Player.Position = new_pos;
                       
        }           
    }
}