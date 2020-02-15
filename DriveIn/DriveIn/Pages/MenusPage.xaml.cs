using DriveIn.Items;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DriveIn.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenusPage : ContentPage
    {
        public MenusPage()
        {
            InitializeComponent();
            var a = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Spacing = 15,
                Children = { new RestItem(null), new RestItem(null) }
            };

            fav.Children.Add(a);

            var b = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Spacing = 15,
                Children = { new RestItem(null), new RestItem(null) }
            };

            latest.Children.Add(b);
        }
    }
}