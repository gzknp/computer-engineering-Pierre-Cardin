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



        async void Button_Clicked(object sender, EventArgs e)
        {
          await  Navigation.PopAsync();
        }
    }
}