using GraphQLService.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLService.Model
{
    public class Query
    {
        ICategoryService _categoryService = null;
        public Query(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public List<Kategori> Categories => _categoryService.GetCategories();
    }
}
