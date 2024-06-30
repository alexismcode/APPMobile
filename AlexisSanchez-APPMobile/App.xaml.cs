using AlexisSanchez_APPMobile.Views;

namespace AlexisSanchez_APPMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}