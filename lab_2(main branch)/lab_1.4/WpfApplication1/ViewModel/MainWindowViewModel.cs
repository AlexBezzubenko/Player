using System;
using System.Windows.Input;
using System.Windows.Data;
using System.Windows.Media;
using TestApp.Model;
using TestApp.View;
 
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Threading;

namespace TestApp.ViewModel
{
    public class MainWindowViewModel
    {       
            public MainWindowViewModel(Window window)
            {
                Playlist = new Playlist("Name");

                Settings = new Settings();

                AboutCommand = new Commands.Main.AboutCommand();
                AddTrackCommand = new Commands.Main.AddTrackCommand();
                RemoveTrackCommand = new Commands.Main.RemoveTrackCommand();
                RateCommand = new Commands.Main.RateCommand(Playlist);
                AddTabItemCommand = new Commands.Main.AddTabItemCommand();
                CloseButtonEnterCommand = new Commands.Main.CloseButtonEnterCommand();
                CloseButtonLeaveCommand = new Commands.Main.CloseButtonLeaveCommand();
                ChangeCurrentCommand = new Commands.Main.ChangeCurrentCommand();
                ChangePositionCommand = new Commands.Main.ChangePositionCommand();
                ChangeVolumeCommand = new Commands.Main.ChangeVolumeCommand();
                PlayCommand = new Commands.Main.PlayCommand();
                PauseCommand = new Commands.Main.PauseCommand();
                StopCommand = new Commands.Main.StopCommand(Settings);
                QueuryCommand = new Commands.Main.QueuryCommand();
                CloseWindowCommand = new Commands.Main.CloseWindowCommand();
                DragMoveCommand = new Commands.Main.DragMoveCommand();
                ButtonMouseElCommand = new Commands.Main.ButtonMouseElCommand();
                PlaylistMoveCommand = new Commands.Main.PlaylistMoveCommand();
                SettingsCommand = new Commands.Main.SettingsCommand(Settings);
                CloseTabItemCommand = new Commands.Main.CloseTabItemCommand();
                NextTrackCommand = new Commands.Main.NextTrackCommand();
                PrevTrackCommand = new Commands.Main.PrevTrackCommand();
                AppSettingsCommand = new Commands.AppCommand.AppSettingsCommand();

                
            }
             
            public Playlist Playlist { get; set; }
            public Settings Settings { get; set;}

            public ICommand QueuryCommand { get; set; }
            public ICommand AddTrackCommand { get; set; }
            public ICommand AboutCommand { get; set; }
            public ICommand RemoveTrackCommand { get; set; }
            public ICommand CloseButtonEnterCommand { get; set; }
            public ICommand CloseButtonLeaveCommand { get; set; }
            public ICommand AddTabItemCommand { get; set; }
            public ICommand ChangeCurrentCommand { get; set; }
            public ICommand ChangePositionCommand { get; set; }
            public ICommand ChangeVolumeCommand { get; set; }
            public ICommand CloseTabItemCommand { get; set; }    

            public ICommand PlayCommand { get; set; }
            public ICommand PauseCommand { get; set; }
            public ICommand StopCommand { get; set; }
            public ICommand CloseWindowCommand { get; set; }
            public ICommand DragMoveCommand { get; set; }
            public ICommand ButtonMouseElCommand { get; set; }
            public ICommand PlaylistMoveCommand { get; set; }
            public ICommand SettingsCommand { get; set; }
            public ICommand RateCommand { get; set; }
            public ICommand NextTrackCommand { get; set; }
            public ICommand PrevTrackCommand { get; set; }
            public ICommand AppSettingsCommand { get; set; }                                    
    }
}
