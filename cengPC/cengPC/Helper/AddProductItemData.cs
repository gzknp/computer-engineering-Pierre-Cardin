using cengPC.Model;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace cengPC.Helper
{
    public class AddProductItemData
    {
        FirebaseClient client;
        public List<ProductItem> ProductItems { get; set; }
        public AddProductItemData()
        {
            client = new FirebaseClient("https://pierrecapp-4a4be-default-rtdb.europe-west1.firebasedatabase.app/");
            ProductItems = new List<ProductItem>()
            {
                new ProductItem
                {
                    ProductID=1,
                    CategoryID=1,
                    ImageUrl="birgomlek.png",
                    Name="Bir Numaralı Gömlek",
                    Description="Bedeni Saran Gömlek",
                    Price=26,
                    Color="Açık"
                },
                new ProductItem
                {
                    ProductID=2,
                    CategoryID=1,
                    ImageUrl="ikigomlek.png",
                    Name="İki Numaralı Gömlek",
                    Description="Bedeni Saran Gömlek",
                    Price=36,
                    Color="Koyu"
                },new ProductItem
                {
                    ProductID=3,
                    CategoryID=1,
                    ImageUrl="ucgomlek.png",
                    Name="Uc Numaralı Gömlek",
                    Description="Bedeni Saran Gömlek",
                    Price=46,
                    Color="Açık"
                },new ProductItem
                {
                    ProductID=4,
                    CategoryID=1,
                    ImageUrl="dortgomlek.png",
                    Name="Dort Numaralı Gömlek",
                    Description="Bedeni Saran Gömlek",
                    Price=56,
                    Color="Açık"
                },new ProductItem
                {
                    ProductID=5,
                    CategoryID=1,
                    ImageUrl="besgomlek.png",
                    Name="Bes Numaralı Gömlek",
                    Description="Bedeni Saran Gömlek",
                    Price=66,
                    Color="Koyu"
                },new ProductItem
                {
                    ProductID=16,
                    CategoryID=1,
                    ImageUrl="altigomlek.png",
                    Name="Alti Numaralı Gömlek",
                    Description="Bedeni Saran Gömlek",
                    Price=86,
                    Color="Koyu"
                },new ProductItem
                {
                    ProductID=17,
                    CategoryID=1,
                    ImageUrl="yedigomlek.png",
                    Name="Yedi Numaralı Gömlek",
                    Description="Bedeni Saran Gömlek",
                    Price=126,
                    Color="Koyu"
                },

                new ProductItem
                {
                    ProductID=6,
                    CategoryID=2,
                    ImageUrl="birceket.png",
                    Name="Bir Numaralı Ceket",
                    Description="Her Toplantıya Uygun Ceket",
                    Price=127,
                    Color="Koyu"
                },new ProductItem
                {
                    ProductID=7,
                    CategoryID=2,
                    ImageUrl="ikiceket.png",
                    Name="İki Numaralı Ceket",
                    Description="Her Toplantıya Uygun Ceket",
                    Price=214,
                    Color="Koyu"
                },new ProductItem
                {
                    ProductID=8,
                    CategoryID=2,
                    ImageUrl="ucceket.png",
                    Name="Uc Numaralı Ceket",
                    Description="Her Toplantıya Uygun Ceket",
                    Price=333,
                    Color="Açık"
                },new ProductItem
                {
                    ProductID=9,
                    CategoryID=2,
                    ImageUrl="dortceket.png",
                    Name="Dort Numaralı Ceket",
                    Description="Her Toplantıya Uygun Ceket",
                    Price=432,
                    Color="Koyu"
                },
                new ProductItem
                {
                    ProductID=10,
                    CategoryID=2,
                    ImageUrl="besceket.png",
                    Name="Bes Numaralı Ceket",
                    Description="Her Toplantıya Uygun Ceket",
                    Price=493,
                    Color="Açık"
                },
                 new ProductItem
                {
                    ProductID=18,
                    CategoryID=2,
                    ImageUrl="alticeket.png",
                    Name="Alti Numaralı Ceket",
                    Description="Her Toplantıya Uygun Ceket",
                    Price=493,
                    Color="Açık"
                },

                new ProductItem
                {
                    ProductID=11,
                    CategoryID=3,
                    ImageUrl="birtshirt.png",
                    Name="Bir Numaralı Tshirt",
                    Description="Yaz aylarına uygun",
                    Price=39,
                    Color="Açık"
                },
                new ProductItem
                {
                    ProductID=12,
                    CategoryID=3,
                    ImageUrl="ikitshirt.png",
                    Name="İki Numaralı Tshirt",
                    Description="Yaz aylarına uygun",
                    Price=99,
                    Color="Açık"
                },new ProductItem
                {
                    ProductID=13,
                    CategoryID=3,
                    ImageUrl="uctshirt.png",
                    Name="Uc Numaralı Tshirt",
                    Description="Yaz aylarına uygun",
                    Price=69,
                    Color="Açık"
                },new ProductItem
                {
                    ProductID=14,
                    CategoryID=3,
                    ImageUrl="dorttshirt.png",
                    Name="Dort Numaralı Tshirt",
                    Description="Yaz aylarına uygun",
                    Price=39,
                    Color="Koyu"
                },new ProductItem
                {
                    ProductID=15,
                    CategoryID=3,
                    ImageUrl="bestshirt.png",
                    Name="Bes Numaralı Tshirt",
                    Description="Yaz aylarına uygun",
                    Price=43,
                    Color="Açık"
                },new ProductItem
                {
                    ProductID=19,
                    CategoryID=3,
                    ImageUrl="altitshirt.png",
                    Name="Alti Numaralı Tshirt",
                    Description="Yaz aylarına uygun",
                    Price=43,
                    Color="Açık"
                },new ProductItem
                {
                    ProductID=20,
                    CategoryID=3,
                    ImageUrl="yeditshirt.png",
                    Name="Yedi Numaralı Tshirt",
                    Description="Yaz aylarına uygun",
                    Price=43,
                    Color="Koyu"
                },new ProductItem
                {
                    ProductID=21,
                    CategoryID=3,
                    ImageUrl="sekiztshirt.png",
                    Name="Sekiz Numaralı Tshirt",
                    Description="Yaz aylarına uygun",
                    Price=43,
                    Color="Koyu"
                },new ProductItem
                {
                    ProductID=22,
                    CategoryID=3,
                    ImageUrl="dokuztshirt.png",
                    Name="Dokuz Numaralı Tshirt",
                    Description="Yaz aylarına uygun",
                    Price=43,
                    Color="Açık"
                },
            };
        }
        public async Task AddProductItemAsync()
        {
            try
            {
                foreach(var item in ProductItems)
                {
                    await client.Child("ProductItems").PostAsync(new ProductItem()
                    {
                        CategoryID=item.CategoryID,
                        ProductID=item.ProductID,
                        Description=item.Description,
                        ImageUrl=item.ImageUrl,
                        Name=item.Name,
                        Price=item.Price,
                        
                    });
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Hata", ex.Message, "OK");
            }
        }
    }
}
