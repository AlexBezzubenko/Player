using System;
using System.Windows.Input;
using System.Windows.Media;
using TestApp.Model;
using TestApp.View;
using TestApp.ViewModel;

namespace TestApp.Commands.Main
{
    public class PauseCommand : ICommand
    {
        public PauseCommand()
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
            if (parameter.GetType() != typeof(Playlist) || parameter == null)
            {
                return;
            }
            ((Playlist)parameter).Player.Pause();
        }  
    }
}