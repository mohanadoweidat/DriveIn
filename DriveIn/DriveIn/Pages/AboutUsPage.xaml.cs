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
    public partial class AboutUsPage : ContentPage
    {
        public AboutUsPage()
        {
            InitializeComponent();
            logo.Source = App.GetSource("Logo.png");
            bg.Source = App.GetSource("gradient.png");

            //TODO
            /*
            label.Text = "";
            label_main.Text = "";
            */
        }
    }
}