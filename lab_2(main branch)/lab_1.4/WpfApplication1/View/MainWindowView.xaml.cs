using System;
using System.Globalization;
using System.Threading;
using System.Windows;
using TestApp.ViewModel;
using TestApp.Model;
 
namespace TestApp.View
{     
    public partial class MainWindowView : Window
    {
        public MainWindowView()
        {
            var dataContext = new MainWindowViewModel(this);     
            this.DataContext = dataContext;
            //dataContext.Settings.Deserialize();
            //dataContext.Settings.ChangeLanguage();          
            InitializeComponent();
        }   

        protected override void OnClosed(EventArgs e)
        {
            var viewModel = DataContext as MainWindowViewModel;
            if (viewModel != null)
            {
                viewModel.Settings.Serialize();
            }           
            base.OnClosed(e);
        }

                                                           
    }
}
