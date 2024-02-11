using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _110124.Models.Product;

namespace _110124.Models.Category
{
    public class CategoryModel
    {
        public CategoryModel(string id, string name, ICollection<ProductModel> products)
        {
            Id = id;
            Name = name;
            Products = products;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public ICollection<ProductModel> Products { get; set; }
    }
}