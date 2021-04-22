using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
[assembly: ExportFont("Blinker-Black.ttf", Alias = "BlBl")]
[assembly: ExportFont("Blinker-Bold.ttf", Alias = "BlBo")]
[assembly: ExportFont("Blinker-ExtraBold.ttf", Alias = "BlEx")]
[assembly: ExportFont("Blinker-Light.ttf", Alias = "BlLi")]
[assembly: ExportFont("Blinker-Regular.ttf", Alias = "BlRe")]
[assembly: ExportFont("Blinker-SemiBold.ttf", Alias = "BlSe")]
[assembly: ExportFont("Blinker-Thin.ttf", Alias = "BlThi")]
[assembly: ExportFont("Roboto-Black.ttf", Alias = "RoBl")]
[assembly: ExportFont("Roboto-Bold.ttf", Alias = "RoBo")]
[assembly: ExportFont("Roboto-Italic.ttf", Alias = "RoIt")]
[assembly: ExportFont("Roboto-Light.ttf", Alias = "RoLi")]
[assembly: ExportFont("Roboto-Medium.ttf", Alias = "RoMe")]
[assembly: ExportFont("Roboto-Regular.ttf", Alias = "RoRe")]
[assembly: ExportFont("Roboto-Thin.ttf", Alias = "RoTh")]

namespace cengPC
{
    public partial class App : Application
    {
        /* static UyeDatabase database;
        public static UyeDatabase UyeDatabase
        {
            get
            {
                if(database==null)
                {
                    database = new UyeDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "uyeler.db3"));
                }
                return database;
            }
        }*/
        static UyeDatabase database;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        public static UyeDatabase Database
        {
            get
            {
                if(database == null)
                {
                    //database = new UyeDatabase(DependencyService.Get<ILocalFileHelper>().GetLocalFilePath("uyelerim.db3"));
                    database = new UyeDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "uyelerim.db3"));
                }
                return database;
            }
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
