using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _110124.Models.Category
{
    public class GetAllCategoryModel
    {
        public GetAllCategoryModel(string id, string name)
        {
            Id = id;
            Name = name;
        }

        [Required]
        public string Id { get; init; }

        [Required]
        public string Name { get; init; }
    }
}