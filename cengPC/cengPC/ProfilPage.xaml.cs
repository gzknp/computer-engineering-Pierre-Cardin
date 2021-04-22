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
    public partial class ProfilPage : ContentPage
    {
        public ProfilPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            UyeListView.ItemsSource = await App.Database.GetUyelerAsync();

        }



        /* async void Button_Clicked(object sender, EventArgs e)
         {
             var uyeItem = (Uye)BindingContext;
             await App.Database.SaveUyeAsync(uyeItem);
             await Navigation.PopAsync();
         }*/
    }
}