using DriveIn.Database;
using DriveIn.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DriveIn.Items
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RestItem : Frame
    {
        private Restaurant r;
        private MenusPage page;

        public RestItem(Restaurant r, MenusPage page)
        {
            this.page = page;
            this.r = r;
            InitializeComponent();
            LoadIcon();
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += (s, e) => {
                page.Navigation.PushAsync(new MenuDisplayPage());
            };
            GestureRecognizers.Add(tap);
        }

        private async void LoadIcon()
        {
            icon.Source = App.GetSource("IMG_3493.JPG");
            //icon.Source = App.ByteToImage((await App.LoadImage(r.Icon)).Data);
            this.BackgroundColor = Color.Transparent;
        }
    }
}