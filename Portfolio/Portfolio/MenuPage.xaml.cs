using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Portfolio
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
            ProfileBT.Clicked += ProfileBT_Clicked;
            MyProjectBT.Clicked += MyProjectBT_Clicked;
            AchievementBT.Clicked += AchievementBT_Clicked;
            GitHubBT.Clicked += GitHubBT_Clicked;
            CodeEXBT.Clicked += CodeEXBT_Clicked;
            ContactBT.Clicked += ContactBT_Clicked;
            YoutubeBT.Clicked += YoutubeBT_Clicked;
        }

        private void YoutubeBT_Clicked(object sender, EventArgs e)
        {
            // new faction
            var url = "https://www.youtube.com/results?search_query=yoasobi";
            Device.OpenUri(new Uri(url));
        }

        private void CodeEXBT_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as FlyoutPage;
            mp.Detail = new NavigationPage(new CodeExperience());
            mp.IsPresented = false;
        }

        private void AchievementBT_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as FlyoutPage;
            mp.Detail = new NavigationPage(new Achievement());
            mp.IsPresented = false;
        }

        private void ContactBT_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as FlyoutPage;
            mp.Detail = new NavigationPage(new Contact());
            mp.IsPresented = false;
        }

        private void GitHubBT_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as FlyoutPage;
            mp.Detail = new NavigationPage(new GitHub());
            mp.IsPresented = false;
        }

        private void MyProjectBT_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as FlyoutPage;
            mp.Detail = new NavigationPage(new MyProject());
            mp.IsPresented = false;
        }

        private void ProfileBT_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as FlyoutPage;
            mp.Detail = new NavigationPage(new MainPage());
            mp.IsPresented = false;
        }
    }
}