using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Threading.Tasks;
using cengPC.Model;

namespace cengPC.ViewModels
{
    public class OdemeViewModel:BaseViewModel
    {
        private int _KartNo;
        public int KartNo
        {
            set
            {
                this._KartNo = value;
                OnPropertyChanged();
            }
            get
            {
                return this._KartNo;
            }
        }
        private string _Adres;
        public string Adres
        {
            set
            {
                this._Adres = value;
                OnPropertyChanged();

            }
            get
            {
                return this._Adres;
            }
        }
        private int _Ccv;
        public int Ccv
        {
            set
            {
                this._Ccv = value;
                OnPropertyChanged();
            }
            get
            {
                return this._Ccv;
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
        public Command RegisterOdemeCommand { get; set; }
        public OdemeViewModel()
        {
            RegisterOdemeCommand = new Command(async () => await RegisterOdemeCommandAsync());
        }
        private async Task RegisterOdemeCommandAsync()
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                var userService = new OdemeService();
                Result = await userService.RegisterOdeme(KartNo, Adres, Ccv);
                if (Result)
                    await Application.Current.MainPage.DisplayAlert("BİLGİ", "Ödeme Bilgileri Kaydedildi", "TAMAM");
                else
                    await Application.Current.MainPage.DisplayAlert("Hata",
                        "Aynı Kart No bir kullanıcı tarafından kullanılıyor", "TAMAM");
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "TAMAM");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
