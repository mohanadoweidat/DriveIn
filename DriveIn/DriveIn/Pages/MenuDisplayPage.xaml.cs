using DriveIn.Items;
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
    public partial class MenuDisplayPage : ContentPage
    {
        public MenuDisplayPage()
        {
            InitializeComponent();
            Items_list.ItemsSource = new List<ItemsGrouping>
            {
                new ItemsGrouping("Burgare Och Mål")
                {
                    new Info{Name = "CheeseBurgare"},
                    new Info{Name = "Hamburgare"}
                },

                new ItemsGrouping("Sallader")
                {
                    new Info{Name = "Kycklingsallad" },
                    new Info{Name = "Kebabsallad" }
                },

                new ItemsGrouping("Dryck")
                {
                    new Info{Name = "Cola 30 cm" },
                    new Info{Name = "Fanta zero 30 cm" }
                },

                new ItemsGrouping("Tillbehör")
                {
                    new Info{Name = "Chicken wings" },
                    new Info{Name = "Mozarella Sticks"}
                },
            };

            //Rest_list.ItemsSource = new List<RestaurantInfo>
            //{
            //     new RestaurantInfo{ RName = "Macdonald", RAddress = "Storagtan 52", ROPTime = "12:00", RWTime = "10 min"}
            //};
        }

        private void Items_list_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as Info;
            DisplayAlert("Tapped", item.Name, "OK");
        }

        private void Items_list_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Info;
            DisplayAlert("Selected", item.Name, "OK");
        }
    }
}