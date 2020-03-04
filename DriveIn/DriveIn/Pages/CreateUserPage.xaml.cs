using DriveIn.Database;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DriveIn.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateUserPage : ContentPage
    {
        private bool created;
        private bool success = false;
        private const int MIN_U_LENGTH = 6;
        private const int MAX_U_LENGTH = 20;
        private const int MIN_P_LENGTH = 6;
        private const int MAX_P_LENGTH = 24;

        public CreateUserPage()
        {
            InitializeComponent();
            crt_btn.Clicked += Create_Clicked;
        }

        //TODO Fix This
        private async void Create_Clicked(object sender, EventArgs e)
        {
            if (created)
            {
                return;
            }
            string n = e_name.Text;
            string p = e_pass.Text;
            if (n != null && p != null)
            {
                if (!(n.Length >= MIN_U_LENGTH && n.Length <= MAX_U_LENGTH))
                {
                    DisplayAlert("Fel", "ID ska vara mellan " + MIN_U_LENGTH
                        + " och " + MAX_U_LENGTH, "Ok");
                    return;
                }
                if (!(p.Length >= MIN_P_LENGTH && p.Length <= MAX_P_LENGTH))
                {
                    DisplayAlert("Fel", "Lösenordet ska vara mellan " +
                        MIN_P_LENGTH + " och " + MAX_P_LENGTH, "Ok");
                    return;
                }
                created = true;
                //App.StartLoading("Register");
                //await DBActions.LoadUsers();
                bool found = true;
                foreach (Accounts users in DBActions.accounts)
                {
                    if (users.Username.ToLower() == n.ToLower())
                    {
                        found = false;
                        break;
                    }
                }
                if (found)
                {
                    success = await DBActions.Process("adduser", new Accounts
                    {
                        Username = n,
                        Password = p,
                        UType = 0
                    });

                    if (success)
                    {
                        await DBActions.LoadAccounts();
                        //TODO Return to Login Page after Signing Up!
                    }
                    else
                    {
                        created = false;
                    }
                }
                else
                {
                    created = false;
                    DisplayAlert("Fel", "Kontot med ID: " + n + " finns redan!", "Ok");
                }
                // App.FinishLoading("Register");
                return;
            }
            else
            {
                DisplayAlert("Fel", "Ange ID och lösenord.", "Ok");
            }
            created = false;
        }
    }
}