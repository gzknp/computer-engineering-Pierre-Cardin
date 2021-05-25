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
    public partial class ProductDetailsView : ContentPage
       
    {
        ProductDetailsViewModel pvm;
        public ProductDetailsView(ProductItem productItem)
        {
            InitializeComponent();
            pvm = new ProductDetailsViewModel(productItem);
            this.BindingContext = pvm;
        }
        async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SearchPage());
        }
    }
}