using DriveIn.Database;
using DriveIn.Pages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DriveIn.Elements;

namespace DriveIn
{
    public partial class App : Application
    {
        public static int ScreenHeight { get; set; }
        public static int ScreenWidth { get; set; }
        public static Page CURRENT_PAGE;
        public static List<Loadable> loadables = new List<Loadable>();

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new LoadingScreen());
        }

        public static void StartLoading(string type)
        {
            foreach (Loadable loadable in loadables)
            {
                loadable.OnLoadStarted(type);
            }
        }

        public static void FinishLoading(string type)
        {
            foreach (Loadable loadable in loadables)
            {
                loadable.OnLoadFinished(type);
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

        public static ImageSource GetSource(string name)
        {
            return ImageSource.FromResource("DriveIn.Images." + name, Assembly.GetExecutingAssembly());
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