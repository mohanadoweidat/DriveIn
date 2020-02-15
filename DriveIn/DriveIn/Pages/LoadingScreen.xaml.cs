using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
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
    public partial class LoadingScreen : ContentPage
    {
        public LoadingScreen()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                Ask();
                return false;
            });
        }

        private async void Ask()
        {
            var l = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.LocationWhenInUse);
            if (l != PermissionStatus.Granted)
            {
                var results = await CrossPermissions.Current.RequestPermissionsAsync(new[] { Permission.LocationWhenInUse });
                if (results.ContainsKey(Permission.LocationWhenInUse))
                {
                    l = results[Permission.LocationWhenInUse];
                }
            }
            if (l == PermissionStatus.Granted)
            {
                //Navigation.PushAsync(new Startsidan());
                Navigation.PushAsync(new WelcomePage());
            }
            else
            {
                var x = await DisplayAlert("Error", "You must allow location access!", "Retry", "Cancel");
                if (x)
                {
                    Ask();
                }
            }
        }
    }
}