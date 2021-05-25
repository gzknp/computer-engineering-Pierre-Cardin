using cengPC.Model;
using cengPC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cengPC.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoryView : ContentPage
    {
        CategoryViewModel cvm;
        public CategoryView(Category category)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, true);
            cvm = new CategoryViewModel(category);
            this.BindingContext = cvm;

        }
        async void CollectionView_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            var selectedProduct = e.CurrentSelection.FirstOrDefault() as ProductItem;
            if (selectedProduct == null)
                return;
            await Navigation.PushAsync(new ProductDetailsView(selectedProduct));
            ((CollectionView)sender).SelectedItem = null;
        }
        async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SearchPage());

        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Filtre());
        }
    }
}