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
    public partial class Contact : ContentPage
    {
        public Contact()
        {
            InitializeComponent();
            facebookBT.Clicked += FacebookBT_Clicked;
            IgBT.Clicked += IgBT_Clicked;
        }

        private void IgBT_Clicked(object sender, EventArgs e)
        {
            // new faction
            var url = "https://www.instagram.com/aon_tunder/";
            Device.OpenUri(new Uri(url));
        }

         private void FacebookBT_Clicked(object sender, EventArgs e)
        {
            // new faction
            var url = "https://www.facebook.com/profile.php/?id=100003793211257";
            Device.OpenUri(new Uri(url));
        }
    }
}