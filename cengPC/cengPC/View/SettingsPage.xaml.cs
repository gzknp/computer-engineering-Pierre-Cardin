using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cengPC.Helper;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cengPC.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }
        async void ButtonCategories_Clicked(System.Object sender, System.EventArgs e)
        {
            var acd = new AddCategoryData();
            await acd.AddCategoriesAsync();
        }
        async void ButtonProducts_Clicked(System.Object sender, System.EventArgs e)
        {
            var afd = new AddProductItemData();
            await afd.AddProductItemAsync();
        }
        void ButtonCart_Clicked(System.Object sender, System.EventArgs e)
        {
            var cct = new CreateCartTable();
            if (cct.CreateTable())
                DisplayAlert("Başarılı", "Cart Table olusturuldu", "TAMAM");
            else
                DisplayAlert("Hata", "Tablo olusurken hata", "TAMAM");
        }
    }
}