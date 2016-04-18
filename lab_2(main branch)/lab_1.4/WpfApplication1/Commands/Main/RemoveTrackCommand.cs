using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TestApp.Model;
using TestApp.View;

namespace TestApp.Commands.Main
{
    public class RemoveTrackCommand : ICommand
    {
        public RemoveTrackCommand()
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
            var playlist = parameter as Playlist;

            if (playlist.CurrentTrack != null)
            {
                 playlist.Remove(playlist.CurrentTrack);
                 playlist.CurrentTrack = null;
            }                                                                                        
        }  
    }
}