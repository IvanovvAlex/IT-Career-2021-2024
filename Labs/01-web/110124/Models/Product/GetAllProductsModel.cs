using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _110124.Models.Product
{
    public class GetAllProductsModel
    {
        public GetAllProductsModel(string id, string name, string imageUrl, decimal price)
        {
            Id = id;
            Name = name;
            ImageUrl = imageUrl;
            Price = price;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }

    }
}