using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cengPC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }
        protected override  void OnAppearing()
        {
            base.OnAppearing();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
           if (!string.IsNullOrWhiteSpace(AdEntry.Text) && !string.IsNullOrWhiteSpace(SoyadEntry.Text) && !string.IsNullOrWhiteSpace(EmailEntry.Text) && !string.IsNullOrWhiteSpace(TelefonEntry.Text) && !string.IsNullOrWhiteSpace(SifreEntry.Text))
            {
                var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UyeDatabse.db");
                var db = new SQLiteConnection(dbpath);
                db.CreateTable<Uye>();

                var item = new Uye()
                {
                    Ad = AdEntry.Text,
                    Soyad = SoyadEntry.Text,
                    Email = EmailEntry.Text,
                    Telefon = TelefonEntry.Text,
                    Sifre = SifreEntry.Text,
                };
                db.Insert(item);
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Tebrikler", "Başarıyla kayıt oldunuz", "tamam", "geri");
                    await Navigation.PopAsync();
                });
                AdEntry.Text = SoyadEntry.Text = EmailEntry.Text = TelefonEntry.Text = SifreEntry.Text = string.Empty;
            }

        }

        async void Button_Clicked(object sender, EventArgs e)
        {
          await  Navigation.PopAsync();
        }
    }
}