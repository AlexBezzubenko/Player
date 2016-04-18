using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using TestApp.Model;
using TestApp.View;

namespace TestApp.Commands.Main
{
    public class ButtonMouseElCommand : ICommand
    {
        public ButtonMouseElCommand()
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
            if (parameter != null)
            {
               
                var playButton = parameter as Button;
                String FilePath = ((Image)playButton.Content).Source.ToString();
                Image i = new Image();
                if (FilePath[FilePath.Length - 5] == '2')
                {
                    FilePath = FilePath.Remove(FilePath.IndexOf("2.png"), 1);
                    playButton.Width = 42;
                    playButton.Height = 42;
                }
                else
                {
                    FilePath.Insert(FilePath.Length - 4, "2");
                    FilePath = FilePath.Insert(FilePath.IndexOf(".png"), "2");
                    playButton.Width = 45;
                    playButton.Height = 45;
                }
                
                i.Source = new BitmapImage(new Uri(FilePath));              
                playButton.Content = i;               
            }                             
        }  
    }
}