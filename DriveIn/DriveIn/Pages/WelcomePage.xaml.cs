using DriveIn.Database;
using DriveIn.Elements;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DriveIn.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : CarouselPage
    {
        private Accounts ad;

        public WelcomePage()
        {
            InitializeComponent();
            nxttbtn.Clicked += Nxttbtn_Clicked;
            log_btn.Clicked += Login_Cliked;
            crt_btn.Clicked += Create_Clicked;
        }

        private void Create_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreateUserPage());
        }

        private void Login_Cliked(object sender, EventArgs e)
        {
            string u = e_name.Text;
            string p = e_pass.Text;
            if (u != null && p != null)
            {
                Accounts a = DBActions.GetAccountByName(u);
                if (a != null && a.Password == p)
                {
                    if (a.UType == 0)
                    {
                        Navigation.PushAsync(new Startsidan());
                    }
                    else
                    {
                        //TODO
                        //Restaurant Page
                    }
                }
                else
                {
                    DisplayAlert("Misslyckad Inloggning", "Ogiltigt användernamn eller lösenord!", "Avbryt");
                }
            }
            else
            {
                DisplayAlert("Misslyckad Inloggning", "Mata in ditt användernamn och lösenord", "Okej");
            }
        }

        private void Nxttbtn_Clicked(object sender, EventArgs e)
        {
            CurrentPage = Children[1];
        }
    }
}