using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using _110124.Data;
using _110124.Data.Entities;
using _110124.Models.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace _110124.Controllers
{
    [Route("[controller]")]
    public class ProductsController : Controller
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly AppDbContext _context;

        public ProductsController(ILogger<ProductsController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet("")]
        [HttpGet("Index")]
        public IActionResult Index()
        {
            ICollection<Product> products = _context.Products.ToList();
            IEnumerable<GetAllProductsModel> model = products.Select(p => new GetAllProductsModel(p.Id, p.Name, p.ImageUrl, p.Price));

            return View(model);
        }

        public IActionResult GetById(string id)
        {
            return View();
        }

        [HttpGet("Create")]
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");

            return View();
        }

        [HttpPost("Create")]
        public IActionResult Create(CreateProductModel model)
        {
            Product product = new Product();
            product.Name = model.Name;
            product.Description = model.Description;
            product.ImageUrl = model.ImageUrl;
            product.Price = model.Price;
            product.Quantity = model.Quantity;
            product.CategoryId = model.CategoryId;

            _context.Products.Add(product);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}