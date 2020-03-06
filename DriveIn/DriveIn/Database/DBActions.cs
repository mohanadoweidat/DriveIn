using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DriveIn.Database
{
    internal class DBActions
    {
        private const string LINK = "http://windows.u7979705.fsdata.se/api/";
        private const string IMAGES = "DImages";
        private const string ACCOUNTS = "DAccounts";
        private const string RESTAURANTS = "DRestaurant";
        private const string MENUS = "DMenu";
        private const string RESERVATIONS = "DReservations";
        public static List<IImage> Images = new List<IImage>();
        public static List<Accounts> accounts = new List<Accounts>();
        public static List<Restaurant> restaurants = new List<Restaurant>();
        public static List<Menu> menus = new List<Menu>();
        public static List<Reservations> reservations = new List<Reservations>();

        public static async Task LoadAccounts()
        {
            //App.StartLoading("Accounts");
            HttpClient client = new HttpClient();
            var responce = await client.GetStringAsync(LINK + ACCOUNTS);
            accounts = JsonConvert.DeserializeObject<List<Accounts>>(responce);
            //App.FinishLoading("Accounts");
        }

        public static Accounts GetAccountByName(string u)
        {
            foreach (Accounts a in accounts)
            {
                if (a.DUsername == u)
                {
                    return a;
                }
            }
            return null;
        }

        public static async Task<HttpResponseMessage> AddUser(Accounts user)
        {
            var json = JsonConvert.SerializeObject(user);
            var c = new StringContent(json, Encoding.UTF8, "application/json");
            HttpClient client = new HttpClient();
            return await client.PostAsync(LINK + ACCOUNTS, c);
        }

        public static async Task<bool> Process(string actionName, params object[] values)
        {
            HttpResponseMessage response = null;
            if (actionName == "adduser")
            {
                response = await AddUser(values[0] as Accounts);
            }
            else if (actionName == "addproduct")
            {
            }
            bool x = response != null && (response.StatusCode == HttpStatusCode.Created || response.StatusCode == HttpStatusCode.NoContent);
            if (!x)
            {
                App.CURRENT_PAGE.DisplayAlert("Fel", response.StatusCode.ToString()
                  + "\nKontakta oss.", "Avbryt");
            }
            return x;
        }

        public static async Task<IImage> LoadImage(string id)
        {
            HttpClient client = new HttpClient();
            try
            {
                var responce = await client.GetStringAsync(LINK + IMAGES + "/" + id);
                return JsonConvert.DeserializeObject<IImage>(responce);
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}