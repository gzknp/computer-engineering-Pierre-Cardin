using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace cengPC.ViewModels
{
    public class NavPages:LoginViewModel
    {
           
        public Command NavProfileCommand { get; set; }
        public Command NavFavoriteCommand { get; set; }
        public Command NavTakipCommand { get; set; }

        public NavPages()
        {
            NavProfileCommand = new Command(async () => await NavProfileCommandAsync());
            NavFavoriteCommand = new Command(async () => await NavFavoriteCommandAsync());
            NavTakipCommand = new Command(async () => await NavTakipCommandAsync());
        }

        private async Task NavTakipCommandAsync()
        {

            if (girildiMi == true)
            {
                await Application.Current.MainPage.Navigation.PushAsync(new NoLogTakipPage());
            }
            else
                await Application.Current.MainPage.Navigation.PushAsync(new NoLogTakipPage());


        }

        private async Task NavFavoriteCommandAsync()
        {

            if (girildiMi == true)
            {
                await Application.Current.MainPage.Navigation.PushAsync(new FavPage());

            }
            else
                await Application.Current.MainPage.Navigation.PushAsync(new LogInPage());


        }

        private async Task NavProfileCommandAsync()
        {

                if (girildiMi==true)
                {
                await Application.Current.MainPage.Navigation.PushAsync(new AccountPage());

            }
            else
                await Application.Current.MainPage.Navigation.PushAsync(new LogInPage());



        }
    }
}
