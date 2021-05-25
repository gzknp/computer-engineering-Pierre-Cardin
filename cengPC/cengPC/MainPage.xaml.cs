using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using cengPC;
using cengPC.ViewModels;
using cengPC.View;
using cengPC.Model;


namespace cengPC
{

    public partial class MainPage : ContentPage
    {
        public static bool girildiMi;
        
        public MainPage()
        {
            NavigationPage.SetHasBackButton(this, false);
            InitializeComponent();
        }
        async void ImageButton_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new SearchPage());
            
        }



        private void ImageButton_Clicked_3(object sender, EventArgs e)
        {

        }

         async void CollectionView_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            var category = e.CurrentSelection.FirstOrDefault() as Category;
            if (category == null)
                return;

            await Navigation.PushAsync(new CategoryView(category));
            ((CollectionView)sender).SelectedItem = null;

        }


        private void ImageButton_Clicked_6(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MorePage());
        }


        //erkek sayfasi koleksiyon butonu clicked işlemi
        private void erkekKoleksiyon(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProductView());
        }

        private void ImageButton_Clicked_7(object sender, EventArgs e)
        {
        }
    }
}
