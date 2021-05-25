using GraphQLService.IService;
using GraphQLService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLService.Service
{
    public class CategoryService : ICategoryService
    {
        public List<Kategori> GetCategories()
        {
            List<Kategori> categories = new List<Kategori>()
            { new Kategori()
            {
                CategoryID = 1,
                CategoryName = "Gömlek",
                ImageUrl = "Gomlek.png"
            },
            new Kategori()
            {
                CategoryID=2,
                CategoryName="Ceket",
                ImageUrl="Ceket.png"
            },
            new Kategori()
            {
                CategoryID=3,
                CategoryName="Tshirt",
                ImageUrl="Tshirt.png"
            },

            };
            return categories;
        }

    }
}
