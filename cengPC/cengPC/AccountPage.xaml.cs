using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cengPC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccountPage : ContentPage
    {
        public AccountPage()
        {
            InitializeComponent();
        }
        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProfilPage());
        }
        private async void ImageButton_Clicked_1(object sender, EventArgs e)
        {
         await Application.Current.MainPage.Navigation.PushModalAsync(new LogInPage());
        }
        private async void ImageButton_Clicked_2(object sender, EventArgs e)
        {
          await Application.Current.MainPage.Navigation.PushModalAsync(new MainPage());

        }
    }
}