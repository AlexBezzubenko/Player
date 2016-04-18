using System;
using System.Windows.Input;
using TestApp.Model;
using TestApp.View;

namespace TestApp.ViewModel
{
    class SettingsWindowViewModel
    {
        public Settings Settings { get; set; }

        public SettingsWindowViewModel(SettingsWindowView settingsWindow, Settings Settings)
        {
            CloseButtonEnterCommand = new Commands.Main.CloseButtonEnterCommand();
            CloseButtonLeaveCommand = new Commands.Main.CloseButtonLeaveCommand();
            CloseWindowCommand = new Commands.Main.CloseWindowCommand();
            DragMoveCommand = new Commands.Main.DragMoveCommand();
            ApplyCommand = new Commands.Settings.ApplyCommand();
            StopChangeCommand  = new Commands.Settings.StopChangeCommand();

            this.Settings = Settings;
        }

        public ICommand AddCommand { get; set; }       
        public ICommand CloseWindowCommand { get; set; }
        public ICommand CloseButtonEnterCommand { get; set; }
        public ICommand CloseButtonLeaveCommand { get; set; }
        public ICommand DragMoveCommand { get; set; }
        public ICommand ApplyCommand { get; set; }
        public ICommand StopChangeCommand { get; set; }
    }
}
