using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using TestApp.Model;

namespace TestApp.Commands.Main
{
    public class NextTrackCommand : ICommand
    {
        public NextTrackCommand()
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
            var textBlock = (TextBlock)values[1];

            if (p == null)
            {
                return;
            }
            Track t = (Track)p.CurrentTrack;
            int i = p.FindIndex(t);
            i++;
            if (i == p.Count)
            {
                i = 0;
            }
            p.CurrentTrack = p[i];


            if (p.CurrentTrack != null && p.CurrentTrack.FileName != null)
            {
                p.Player.Open(new Uri(p.CurrentTrack.FileName, UriKind.Relative));
                textBlock.Text = MakeTicker(p.CurrentTrack);
            }

            Thread thread = new Thread(new ParameterizedThreadStart(m));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start(p.Player);                    
        }
        private string MakeTicker(Track track)
        {
            string result = String.Concat(".:: ", track.TrackLength.ToString("mm\\:ss"), " :: ", track.Artist, " - ",
                                        track.TrackName, " :: Genre - ", track.Genre, " ::.");
            return result;
        }
                 
        public static void m(object obj)
        {
            MediaPlayer p = (MediaPlayer)obj;
            p.Dispatcher.BeginInvoke(new ThreadStart(delegate { p.Play(); }));
        }
    }
}