using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cengPC.Model
{
   public  class ProductItemService
    {
        FirebaseClient client;
        public ProductItemService()
        {
            client = new FirebaseClient("https://pierrecapp-4a4be-default-rtdb.europe-west1.firebasedatabase.app/");
        }
        public async Task<List<ProductItem>> GetProductItemAsync()
        {
            var product = (await client.Child("ProductItems")
                .OnceAsync<ProductItem>())
                .Select(f => new ProductItem
                {
                    CategoryID = f.Object.CategoryID,
                    Description = f.Object.Description,
                    ImageUrl = f.Object.ImageUrl,
                    Name = f.Object.Name,
                    ProductID = f.Object.ProductID,
                    Price = f.Object.Price,
                    Color=f.Object.Color
                }).ToList();
            return product;
        }
        public async Task<ObservableCollection<ProductItem>> GetProductItemsByCategoryAsync(int categorID)
        {
            var productItemsByCategory = new ObservableCollection<ProductItem>();
            var items = (await GetProductItemAsync()).Where(p => p.CategoryID == categorID).ToList();
            foreach(var item in items)
            {
                productItemsByCategory.Add(item);
            }
            return productItemsByCategory;
        }
    
    }
}
