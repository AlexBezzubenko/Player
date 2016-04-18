using System;
using System.Windows.Input;
using TestApp.Model;
using TestApp.View;
using System.Windows;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media;
using System.Threading;
using Microsoft.Win32;
using System.Windows.Threading;


namespace TestApp.Commands.Main
{
    public class QueuryCommand : ICommand
    {
        MediaPlayer player2;
        MediaPlayer player;

        public QueuryCommand()

        {
            //player2 = new MediaPlayer();
            //this.player = player;                             
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

        public void Execute(object parametr)
        {
            var values = (object[])parametr;
            var i = values[0];
            //var string1 = (string)values[1];
            //var ti = (TabItem)values[2];
            //m();    
            //

            Thread t = new Thread(new ParameterizedThreadStart(m));
            t.SetApartmentState(ApartmentState.STA);
            Thread.Sleep(TimeSpan.FromSeconds(3));
            t.Start(player2);
            //MessageBox.Show(i.GetType().ToString());
            //var oldWindow = Application.Current.MainWindow;
            //Application.Current.MainWindow = new MainWindowView();
            //Application.Current.MainWindow.Show();
            //oldWindow.Close();            
        }

        public static void m(object obj)
        {
            MediaPlayer p = (MediaPlayer)obj;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                p.Dispatcher.BeginInvoke(new ThreadStart(delegate { p.Open(new Uri(openFileDialog.FileName)); }));
                p.Dispatcher.BeginInvoke(new ThreadStart(delegate { p.Play(); }));
                //p.Open(new Uri(openFileDialog.FileName));
                 
            }
        }
        
    }
}