using DriveIn.Database;
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
        Restaurant r;

		public RestItem (Restaurant r)
		{
            this.r = r;
			InitializeComponent ();
            LoadIcon();
		}

        private async void LoadIcon()
        {
            icon.Source = App.ByteToImage((await App.LoadImage(r.Icon)).Data);
            this.BackgroundColor = Color.Transparent;
        }

	}
}