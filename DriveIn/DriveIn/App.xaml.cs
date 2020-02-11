using DriveIn.Database;
using DriveIn.Pages;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DriveIn
{
    public partial class App : Application
    {

        private const string LINK = "http://windows.u7979705.fsdata.se/api/";
        private const string DI = "DriveImages";

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new LoadingScreen());
        }

        public static async Task<IImage> LoadImage(string id)
        {
            HttpClient client = new HttpClient();
            try
            {
                var responce = await client.GetStringAsync(LINK + DI + "/" + id);
                return JsonConvert.DeserializeObject<IImage>(responce);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        //public static byte[] ImageToByte(MediaFile file)
        //{
        //    using (var memoryStream = new MemoryStream())
        //    {
        //        file.GetStream().CopyTo(memoryStream);
        //        // file.Dispose();
        //        byte[] i = memoryStream.ToArray();
        //        return i;
        //    }
        //}

        public static ImageSource ByteToImage(byte[] b)
        {
            return ImageSource.FromStream(() => new MemoryStream(b));
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}