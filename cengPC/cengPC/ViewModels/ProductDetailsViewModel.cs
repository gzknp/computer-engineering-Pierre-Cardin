using cengPC.Model;
using cengPC.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace cengPC.ViewModels
{
    public class ProductDetailsViewModel:BaseViewModel
    {
        private ProductItem _SelectedProductItem;
        public ProductItem SelectedProductItem
        {           
            set 
            {
                _SelectedProductItem = value;
                OnPropertyChanged();
            }

            get 
            { 
                return _SelectedProductItem; 
            }
        }
        private int _TotalQuantity;
        public int TotalQuantity
        {           
            set 
            { 
                this._TotalQuantity = value;
                if (this._TotalQuantity < 0)
                    this._TotalQuantity = 0;
                if (this._TotalQuantity > 10)
                    this._TotalQuantity -= 1;
                OnPropertyChanged();
            }

            get 
            { 
                return _TotalQuantity; 
            }
        }

        public Command IncrementOrderCommand { get; set; }
        public Command DecrementOrderCommand { get; set; }
        public Command AddToCartCommand { get; set; }
        public Command ViewCartCommand { get; set; }
        public Command HomeCommand { get; set; }
        public ProductDetailsViewModel(ProductItem productItem)
        {
            SelectedProductItem = productItem;
            TotalQuantity = 0;

            IncrementOrderCommand = new Command(() => IncrementOrder());
            DecrementOrderCommand = new Command(() => DecrementOrder());
            AddToCartCommand = new Command(() => AddToCart());
            ViewCartCommand = new Command(async() => await ViewCartAsync());
            HomeCommand = new Command(async () => await GotoHomeAsync());
        }

        private async Task GotoHomeAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ProductView());

        }

        private async Task ViewCartAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new CartView());
        }

        private void AddToCart()
        {
            var cn = DependencyService.Get<ISQLite>().GetConnection();
            try
            {
                CartItem ci = new CartItem()
                {
                    ProductId = SelectedProductItem.ProductID,
                    ProductName = SelectedProductItem.Name,
                    Price = SelectedProductItem.Price,
                    ImageUrl=SelectedProductItem.ImageUrl,
                    Quantity = TotalQuantity
                };
                var item = cn.Table<CartItem>().ToList()
                    .FirstOrDefault(c => c.ProductId == SelectedProductItem.ProductID);
                if (item == null)
                    cn.Insert(ci);
                else
                {
                    item.Quantity += TotalQuantity;
                    cn.Update(item);
                }
                cn.Commit();
                cn.Close();
                Application.Current.MainPage.DisplayAlert("Bilgi", "Seçilen ürün sepete eklendi", "TAMAM");
            }
            catch(Exception ex)
            {
                Application.Current.MainPage.DisplayAlert("Hata", ex.Message, "TAMAM");
            }
            finally
            {
                cn.Close();
            }
        }

        private void DecrementOrder()
        {
            TotalQuantity--;
        }

        private void IncrementOrder()
        {
            TotalQuantity ++;
        }
    }
}
