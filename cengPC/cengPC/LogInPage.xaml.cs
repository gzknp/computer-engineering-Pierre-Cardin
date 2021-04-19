using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cengPC
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogInPage : ContentPage
    {
        
        public LogInPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());

        }

        async void Button_Clicked_1(object sender, EventArgs e)
        {
            var instance = new MainPage();
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UyeDatabse.db");
            var db = new SQLiteConnection(dbpath);
            var myquery = db.Table<Uyeler>().Where(u => u.Email.Equals(EntryEmail.Text) && u.Sifre.Equals(EntrySifre.Text)).FirstOrDefault();
            if (myquery!=null)
            {
                MainPage.girildiMi = true;
                Navigation.PopAsync();
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Hata", "Yanlış mail ya da şifre", "tamam", "geri");
                    await Navigation.PopAsync();
                });
            }
        }
    }
}