using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using cengPC;

namespace cengPC
{
    public class LoginViewModel: BaseViewModel
    {
        public static bool girildiMi;

        private string _Email;
        public string Email
        {
            set
            {
                this._Email = value;
                OnPropertyChanged();
            }
            get
            {
                return this._Email;
            }
        }

        private string _Password;
        public string Password
        {
            set
            {
                this._Password = value;
                OnPropertyChanged();

            }
            get
            {
                return this._Password;
            }
        }
        
        private bool _IsBusy;
        public bool IsBusy
        {
            set
            {
                this._IsBusy = value;
                OnPropertyChanged();
            }
            get
            {
                return this._IsBusy;
            }
        }
        private bool _Result;
        public bool Result
        {
            set
            {
                this._Result = value;
                OnPropertyChanged();
            }
            get
            {
                return this._Result;
            }
        }
        public Command LoginCommand { get; set; }
       
        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await LoginCommandAsync());
        }



        private async Task LoginCommandAsync()
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                var userService = new UserService();
                Result = await userService.LoginUser(Email, Password);
                if (Result)
                {
                    Preferences.Set("Email", Email);                    
                    girildiMi = true;
                    Application.Current.MainPage = new NavigationPage(new MainPage());
                }
                else
                    await Application.Current.MainPage.DisplayAlert("Hata", "Yanlış Email veya Şifre", "OK");

            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }

}
