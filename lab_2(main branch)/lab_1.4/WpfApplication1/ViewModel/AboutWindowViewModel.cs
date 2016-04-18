using System;
using System.Windows.Input;
using TestApp.Model;
using TestApp.View;

namespace TestApp.ViewModel
{
    class AboutWindowViewModel
    {
        public AboutWindowViewModel(AboutWindowView settingsWindow)
        {
            CloseButtonEnterCommand = new Commands.Main.CloseButtonEnterCommand();
            CloseButtonLeaveCommand = new Commands.Main.CloseButtonLeaveCommand();
            CloseWindowCommand = new Commands.Main.CloseWindowCommand();
            DragMoveCommand = new Commands.Main.DragMoveCommand();
        }
      
        public ICommand CloseWindowCommand { get; set; }
        public ICommand CloseButtonEnterCommand { get; set; }
        public ICommand CloseButtonLeaveCommand { get; set; }
        public ICommand DragMoveCommand { get; set; }
    }
}
