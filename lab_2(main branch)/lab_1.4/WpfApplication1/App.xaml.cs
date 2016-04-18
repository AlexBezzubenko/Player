using System.Windows;
using TestApp.View;
using TestApp.ViewModel;

namespace TestApp
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var mw = new MainWindowView();                                
            mw.Show();
        }       
    }
}
