using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DriveIn.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RestaurantPage : TabbedPage
    {
        public RestaurantPage()
        {
            InitializeComponent();
            about_btn.Clicked += About_btn_Clicked;
            logout_btn.Clicked += Logout_btn_Clicked;
        }

        private async void Logout_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WelcomePage());
        }

        private void About_btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutUsPage());
        }
    }
}