using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cengPC.Model
{
    public class CategoryDataService
    {
        FirebaseClient client;
        public CategoryDataService()
        {
            client = new FirebaseClient("https://pierrecapp-4a4be-default-rtdb.europe-west1.firebasedatabase.app/");
        }

        public async Task<List<Category>> GetCategoriesAsync()
        {
            var categories = (await client.Child("Categories")
                .OnceAsync<Category>())
                .Select(c => new Category
                {
                    CategoryID = c.Object.CategoryID,
                    CategoryName = c.Object.CategoryName,
                    CategoryPoster = c.Object.CategoryPoster,
                    ImageUrl = c.Object.ImageUrl
                }).ToList();
            return categories;
        }
    }
}
