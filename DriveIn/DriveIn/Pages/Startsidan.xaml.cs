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
        private Random r = new Random();
        private bool running = false;

        public Startsidan()
        {
            InitializeComponent();
            AbsoluteLayout.SetLayoutBounds(btn2, new Rectangle(10, App.ScreenHeight-10-76, 76, 76));
            var map = new Map(MapSpan.FromCenterAndRadius(
            new Position(56.05883, 12.7326381), Distance.FromMiles(3)))
            {
                IsShowingUser = true,
            };
            Device.StartTimer(TimeSpan.FromSeconds(1), () => {
                if (!running)
                {
                    if (r.Next(1, 100) > 75)
                    {
                        Run(map);
                    }
                }
                return true;
            });
            st.Children.Add(map);
        }

        private void Run(Map map)
        {
            int A = r.Next(5, 15);
            running = true;
            Device.StartTimer(TimeSpan.FromMilliseconds(50), () => {
                if(map.RotationY < A)
                {
                    map.RotationY+=0.5;
                } else if(map.RotationY > A)
                {
                    map.RotationY-=0.5;
                } else
                {
                    running = false;
                    return false;
                }
                return true;
            });
        }

        private void FlexButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MenusPage());
        }
    }
}