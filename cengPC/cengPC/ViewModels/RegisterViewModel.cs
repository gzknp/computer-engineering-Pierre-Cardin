using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace cengPC.ViewModels
{
    public class RegisterViewModel:BaseViewModel
    {
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
        private string _Name;
        public string Name
        {
            set
            {
                this._Name = value;
                OnPropertyChanged();
            }
            get
            {
                return this._Name;
            }
        }
        private string _LastName;
        public string LastName
        {
            set
            {
                this._LastName = value;
                OnPropertyChanged();
            }
            get
            {
                return this._LastName;
            }
        }
        private string _TelNo;
        public string TelNo
        {
            set
            {
                this._TelNo = value;
                OnPropertyChanged();
            }
            get
            {
                return this._TelNo;
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
        public Command RegisterCommand { get; set; }

        public RegisterViewModel()
        {
            RegisterCommand = new Command(async () => await RegisterCommandAsync());
        }
        private async Task RegisterCommandAsync()
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                var userService = new UserService();
                Result = await userService.RegisterUser(Email, Password, TelNo, Name, LastName);
                if (Result)
                    await Application.Current.MainPage.DisplayAlert("Tebrikler", "Kayıt Başarılı", "OK");
                else
                    await Application.Current.MainPage.DisplayAlert("Hata",
                        "Aynı mail bir kullanıcı tarafından kullanılıyor", "OK");
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
