using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace DriveIn.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Startsidan : ContentPage
    {
        public Startsidan()
        {
            InitializeComponent();
            var map = new Map(MapSpan.FromCenterAndRadius(
               new Position(56.05883, 12.7326381), Distance.FromMiles(3)))
            {
                IsShowingUser = true,
            };
            st.Children.Add(map);
        }
    }
}