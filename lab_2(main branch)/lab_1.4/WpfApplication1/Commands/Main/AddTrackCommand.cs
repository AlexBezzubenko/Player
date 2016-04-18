using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TestApp.Model;
using TestApp.View;

namespace TestApp.Commands.Main
{
    public class AddTrackCommand : ICommand
    {
        private Playlist playlist;
        public AddTrackCommand()
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
            var tabItem = parameter as TabItem;
   
            if (tabItem.Content != null && tabItem.Content.GetType() == typeof(Playlist))
            {
                this.playlist = (Playlist)tabItem.Content;

                Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
                dlg.FileName = ""; // Default file name
                dlg.DefaultExt = ".mp3"; // Default file extension
                dlg.Filter = "Text documents (.mp3)|*.mp3"; // Filter files by extension

                // Show open file dialog box
                Nullable<bool> result = dlg.ShowDialog();

                // Process open file dialog box results
                if (result == true)
                {
                    // Open document
                    string filename = dlg.FileName;
                    
                    playlist.Add(new Track(filename));                                           
                }       
            }                                  
        }  
    }
}