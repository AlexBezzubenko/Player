using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using TestApp.Model;
using TestApp.View;
using TestApp.ViewModel;

namespace TestApp.Commands.Main
{
    public class PlaylistMoveCommand : ICommand
    {       
        public PlaylistMoveCommand()
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
            var stackpanel = parameter as StackPanel;

            DoubleAnimation da = new DoubleAnimation();
            if (stackpanel.Height == 20)
            {
                da.To = 280;
                da.Duration = TimeSpan.FromSeconds(0.3);
                stackpanel.BeginAnimation(Border.HeightProperty, da);
                 
            }
            else
            {
                da.To = 20;
                da.Duration = TimeSpan.FromSeconds(0.3);
                stackpanel.BeginAnimation(Border.HeightProperty, da);
                 
            }
        }  
    }
}