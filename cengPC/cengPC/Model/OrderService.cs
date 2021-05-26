using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace cengPC.Model
{
    public class OrderService
    {
        FirebaseClient client;
        public OrderService()
        {
            client = new FirebaseClient("https://pierrecapp-4a4be-default-rtdb.europe-west1.firebasedatabase.app/");
        }
        public async Task<string> PlaceOrderAsync()
        {
            var cn = DependencyService.Get<ISQLite>().GetConnection();
            var data = cn.Table<CartItem>().ToList();
            var orderId = Guid.NewGuid().ToString();
            var uname = Preferences.Get("Username", "Kullanici");
            decimal totalCost = 0;
            foreach(var item in data)
            {
                OrderDetail od = new OrderDetail()
                {
                    OrderId = orderId,
                    OrderDetailId = Guid.NewGuid().ToString(),
                    ProductID = item.ProductId,
                    ProductName = item.ProductName,
                    ImageUrl=item.ImageUrl,
                    Price = item.Price,
                    Quantity = item.Quantity
                };
                totalCost += item.Price * item.Quantity;
                await client.Child("OrderDetails").PostAsync(od);
            }
            await client.Child("Orders").PostAsync(
                new Order()
                {
                    OrderId = orderId,
                    Username = uname,
                    TotalCost = totalCost
                });
            return orderId;
        }
    }
}
