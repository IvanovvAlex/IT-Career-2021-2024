using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _110124.Models.Product
{
    public class CreateProductModel
    {
        public CreateProductModel()
        {

        }
        public CreateProductModel(string name, string description, string imageUrl, decimal price, int quantity, string categoryId)
        {
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
            Price = price;
            Quantity = quantity;
            CategoryId = categoryId;
        }


        public string Name { get; init; }

        public string Description { get; init; }

        public string ImageUrl { get; init; }

        public decimal Price { get; init; }

        public int Quantity { get; init; }
        public string CategoryId { get; set; }

    }
}