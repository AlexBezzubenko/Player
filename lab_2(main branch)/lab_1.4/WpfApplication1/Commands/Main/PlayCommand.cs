using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using TestApp.Model;
using TestApp.View;
using TestApp.ViewModel;

namespace TestApp.Commands.Main
{
    public class PlayCommand : ICommand
    {
        private Track currentTrack;
        private static SemaphoreSlim s = new SemaphoreSlim(2);
        public PlayCommand()
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
            
            if (values[0].GetType() != typeof(Playlist)){
                return;
            }
            var playlist = (Playlist)values[0];
            var textBlock = (TextBlock)values[1];
          
            if (this.currentTrack != playlist.CurrentTrack
                    && playlist.CurrentTrack != null
                    && playlist.CurrentTrack.FileName != null)
                {
                    this.currentTrack = playlist.CurrentTrack;
                    playlist.Player.Open(new Uri(currentTrack.FileName, UriKind.Relative));
                    textBlock.Text = MakeTicker(currentTrack);
                }
            new Thread(m).Start(playlist.Player);
        


            //int nWorkerThreads;
           // int nCompletionThreads;
            //ThreadPool.GetMaxThreads(out nWorkerThreads, out nCompletionThreads);
           // MessageBox.Show("Максимальное количество потоков: " + nWorkerThreads
           //     + "\nПотоков ввода-вывода доступно: " + nCompletionThreads);

           // ThreadPool.QueueUserWorkItem(new WaitCallback(m), playlist.Player);
            
                //Thread t = new Thread(new ParameterizedThreadStart(m));
                //t.IsBackground = true;
                ///t.SetApartmentState(ApartmentState.STA);
                ///t.Start(playlist.Player);            
        }

        private string MakeTicker(Track track)
        {
            string result = String.Concat(".:: ",track.TrackLength.ToString("mm\\:ss")," :: ", track.Artist, " - ",
                                        track.TrackName," :: Genre - ",track.Genre," ::.");
            return result;
        }

        public static void m(object obj)
        {
            s.Wait();
            MediaPlayer p = (MediaPlayer)obj;
            p.Dispatcher.BeginInvoke(new ThreadStart(delegate { p.Play(); }));
            s.Release();
        }
    }
}