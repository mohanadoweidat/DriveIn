using DriveIn.Elements;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DriveIn.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : CarouselPage
    {
        public WelcomePage()
        {
            InitializeComponent();

            //e_name.HeightRequest = App.ScreenHeight / 12;
            //e_pass.HeightRequest = App.ScreenHeight / 12;
            fr1.Margin = new Thickness(App.ScreenWidth / 24,
                15, App.ScreenWidth / 24, 0);
            fr.Margin = new Thickness(App.ScreenWidth / 24,
              App.ScreenHeight / 64, App.ScreenWidth / 24, 0);
            e_name.FontSize = IFont.Calc(e_name.HeightRequest);
            e_pass.FontSize = IFont.Calc(e_pass.HeightRequest);
            nxttbtn.Clicked += Nxttbtn_Clicked;
            log_btn.Clicked += Login_Cliked;
        }

        //TODO
        //private void Start()
        //{
        //    bool first = false;
        //    if (ad is Admins)
        //    {
        //        if ((ad as Admins).ID == App.ACCOUNT_NAME)
        //        {
        //            Navigation.PushAsync(new ManagePage());
        //            return;
        //        }
        //        first = !(ad as Admins).Login;
        //    }
        //    if (first)
        //    {
        //        Navigation.PushAsync(new FirstLogin(ad as Admins));
        //    }
        //    else
        //    {
        //        Navigation.PushAsync(new MapPage(ad));
        //    }
        //    App.RemovePage(this);
        //}

        //TODO
        private void Login_Cliked(object sender, EventArgs e)
        {
            //string u = e_name.Text;
            //string p = e_pass.Text;
            //if (u != null && p != null)
            //{
            //    bool found = false;
            //    foreach (Admins acc in DBActions.admins)
            //    {
            //        if (u == acc.ID && p == acc.Password)
            //        {
            //            found = true;
            //            ad = acc;
            //        }
            //    }
            //    foreach (Guests g in DBActions.guests)
            //    {
            //        if (u == g.Name && p == g.Password)
            //        {
            //            found = true;
            //            ad = g;
            //        }
            //    }
            //    if (found)
            //    {
            //        if (!signed)
            //        {
            //            signed = true;
            //            if (ad is Guests)
            //            {
            //                Application.Current.Properties["Logged"] = ((Guests)ad).ID;
            //                Application.Current.SavePropertiesAsync();
            //            }
            //            Device.StartTimer(TimeSpan.FromSeconds(2), () =>
            //           {
            //               Start();
            //               return false;
            //           });
            //        }
            //    }
            //    else
            //    {
            //        DisplayAlert("Misslyckad Inloggning", "Ogiltigt användernamn eller lösenord!", "Avbryt");
            //    }
            //}
            //else
            //{
            //    DisplayAlert("Misslyckad Inloggning", "Mata in ditt användernamn och lösenord", "Okej");
            //}
        }

        private void Nxttbtn_Clicked(object sender, EventArgs e)
        {
            CurrentPage = Children[1];
        }
    }
}