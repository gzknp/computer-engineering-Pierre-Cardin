using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cengPC.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderView : ContentPage
    {
        public OrderView(string id)
        {
            NavigationPage.SetHasBackButton(this, false);
            InitializeComponent();
            LabelName.Text = "Welcome" + Preferences.Get("Username", "Guest") + ",";
            LabelOrderID.Text = id;
        }
        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}