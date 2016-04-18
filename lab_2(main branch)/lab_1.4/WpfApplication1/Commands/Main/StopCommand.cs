using System;
using System.Threading;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using TestApp.Model;
using TestApp.View;
using TestApp.ViewModel;

namespace TestApp.Commands.Main
{
    public class StopCommand : ICommand
    {
        TestApp.Model.Settings settings;
        public StopCommand(Model.Settings settings)
        {
            this.settings = settings;
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
            TabControl t = (TabControl)parameter;
            if (!settings.StopAll)
            {
                ((Playlist)t.SelectedContent).Player.Stop();
                return;
            }
            for (int i = 0; i < t.Items.Count;i++)
            {
                if (((TabItem)t.Items[i]).Content != null)
                ((Playlist)((TabItem)t.Items[i]).Content).Player.Stop(); 
            }      
        }  
    }
}