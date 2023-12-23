using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Portfolio
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();


            //NavigationPage
            var page1 = new MainPage();
            var np = new NavigationPage(page1);


            var fp = new FlyoutPage();
            fp.Flyout = new MenuPage();
            fp.Detail = new NavigationPage(new MainPage());

            MainPage = fp;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
