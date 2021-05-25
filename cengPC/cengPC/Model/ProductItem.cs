using System;
using System.Collections.Generic;
using System.Text;

namespace cengPC.Model
{
    public class ProductItem
    {
        public int ProductID { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryID { get; set; }
        public string Color { get; set; }
    }
}
