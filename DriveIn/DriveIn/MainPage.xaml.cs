using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DriveIn
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //ts.Tapped += Ts_Tapped;
        }

        //private async void Ts_Tapped(object sender, EventArgs e)
        //{
        //    await ((Frame)sender).ScaleTo(0.8, 50, Easing.Linear);
        //    //Wait a moment
        //    await Task.Delay(100);
        //    //Scale to normal
        //    await ((Frame)sender).ScaleTo(1, 50, Easing.Linear);
        //}
    }
}