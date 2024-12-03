using Microsoft.Maui.Controls;

namespace SimpleNavigationApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }
    }
}