using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using _110124.Data;
using _110124.Data.Entities;
using _110124.Models.Category;
using _110124.Models.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace _110124.Controllers
{
    [Route("[controller]")]
    public class CategoriesController : Controller
    {
        private readonly ILogger<CategoriesController> _logger;
        private readonly AppDbContext _context;

        public CategoriesController(ILogger<CategoriesController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet("")]
        [HttpGet("Index")]
        public async Task<IActionResult> Index()
        {
            IEnumerable<Category> categories = await _context.Categories.ToListAsync();
            IEnumerable<GetAllCategoryModel> categoryModels = categories.Select(c => new GetAllCategoryModel(c.Id, c.Name));
            return View(categoryModels);
        }
        [HttpGet("{id}")]
        [HttpGet("Index/{id}")]

        public async Task<IActionResult> GetById(string id)
        {
            Category category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            ICollection<Product> products = await _context.Products.Where(p => p.CategoryId == id).ToListAsync();
            ICollection<ProductModel> productModels = products.Select(p => new ProductModel(p.Id, p.Name, p.Description, p.ImageUrl, p.Price, p.Quantity)).ToList();

            return View(new CategoryModel(category.Id, category.Name, productModels));
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}