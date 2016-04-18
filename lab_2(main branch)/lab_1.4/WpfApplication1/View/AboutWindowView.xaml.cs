using System;
using System.Windows;
using TestApp.ViewModel;
using TestApp.Model;

namespace TestApp.View
{
    /// <summary>
    /// Логика взаимодействия для add_window.xaml
    /// </summary>
    public partial class AboutWindowView : Window
    {
        public AboutWindowView()
        {
            InitializeComponent();
            DataContext = new AboutWindowViewModel(this);
        }
    }
}
