using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQLService.Model;

namespace GraphQLService.IService
{
    public interface ICategoryService
    {
       
        List<Kategori> GetCategories();
    }
}
