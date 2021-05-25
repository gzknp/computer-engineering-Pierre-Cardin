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
    public class AddCategoryData
    {
        public List<Category> Categories { get; set; }
        FirebaseClient client;
        public AddCategoryData()
        {
            client = new FirebaseClient("https://pierrecapp-4a4be-default-rtdb.europe-west1.firebasedatabase.app/");
            Categories = new List<Category>()
            {
                new Category()
                {
                    CategoryID=1,
                    CategoryName="Gomlek",
                    CategoryPoster="MainGomlek",
                    ImageUrl="Erkek.png"
                },              
                new Category()
                {
                    CategoryID=2,
                    CategoryName="Ceket",
                    CategoryPoster="MainCeket",
                    ImageUrl="Ceket.png"
                },                
                new Category()
                {
                    CategoryID=3,
                    CategoryName="Tshirt",
                    CategoryPoster="MainTshirt",
                    ImageUrl="Tshirt.png"
                }       
            };
        }
        public async Task AddCategoriesAsync()
        {
            try
            {
                foreach(var category in Categories)
                {
                    await client.Child("Categories").PostAsync(new Category()
                    {
                        CategoryID = category.CategoryID,
                        CategoryName = category.CategoryName,
                        CategoryPoster = category.CategoryPoster,
                        ImageUrl = category.ImageUrl
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
