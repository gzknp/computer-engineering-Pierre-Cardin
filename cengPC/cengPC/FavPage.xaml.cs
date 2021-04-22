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
    public partial class FavPage : ContentPage
    {
        public FavPage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}