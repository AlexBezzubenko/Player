using System;
using System.Windows;
using TestApp.ViewModel;
using TestApp.Model;

namespace TestApp.View
{
    /// <summary>
    /// Логика взаимодействия для add_window.xaml
    /// </summary>
    public partial class SettingsWindowView : Window
    {      
        public SettingsWindowView(Model.Settings settings)
        {
            InitializeComponent();
            DataContext = new SettingsWindowViewModel(this,settings);
        }

        private void stop_apply_Checked(object sender, RoutedEventArgs e)
        {

        }         
    }
}
