using DriveIn.Items;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DriveIn.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenusPage : ContentPage
    {
        private int N = 4;

        public MenusPage()
        {
            InitializeComponent();
            List<RestItem> list = new List<RestItem>();
            for (int x = 0; x < 18; x++)
            {
                list.Add(new RestItem(null, this));
            }
            StackLayout line = null;
            for (int x = 0; x < list.Count; x++)
            {
                if (x % N == 0)
                {
                    line = new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Spacing = 8
                    };
                }
                line.Children.Add(list[x]);
                if (x % N == N - 1 || x == list.Count - 1)
                {
                    fav.Children.Add(line);
                }
            }
            //latest.Children.Add(b);
        }
    }
}