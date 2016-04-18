using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TestApp.Model;
using TestApp.View;
using TestApp.ViewModel;

namespace TestApp.Commands.Main
{
    public class RateCommand : ICommand
    {
        Playlist p;
        public RateCommand(Playlist p)
        {
            this.p = p;
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
                /*var t = (Track)parameter;
                if (t.Rating != 5)
                {
                    t.Rating = 5;                
                    t.TrackName = "asd";
                    p.Add(new Track());
                    return;
                }
                if (t.Rating == 5)
                    t.Rating = 0;*/
            }
        }
    }
}